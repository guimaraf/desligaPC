using System;
using System.Windows.Forms;

namespace DesligandoPC
{
    [Serializable]
    public partial class Form1 : Form
    {
        private int timeCalculate = 0;
        private int translateId = 0;
        public string version = "1.8";
        private bool clockActive = false, shutdownEnable = false;

        public Form1()
        {
            InitializeComponent();
        }

        #region Menu events
        private void AboutMenuItem_Click(object sender, EventArgs e)
        {
            FormSobre newForm = new FormSobre();
            newForm.Show();
            newForm.TranslateApp(translateId);
            this.Hide();
        }
        private void ExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void RebootMenuItem_Click(object sender, EventArgs e)
        {
            WinPower.Execute(WinPower.PowerOption.Reboot);
        }
        private void HibernateMenuItem_Click(object sender, EventArgs e)//Hibernar direto
        {
            Hibernar();
        }
        private void ShutdownMenuItem_Click(object sender, EventArgs e)
        {
            Shutdown();
        }
        private void PortugueseMenuItem_Click(object sender, EventArgs e)//Tradução português
        {
            translateId = 0;
            TranslateApp();
        }
        private void EnglishMenuItem_Click(object sender, EventArgs e)//Tradução Inglês
        {
            translateId = 1;
            TranslateApp();
        }
        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            if (!shutdownEnable)
            {
                if (textBox1.TextLength > 0)
                {
                    shutdownEnable = true;
                    CalculeTime();
                    TranslateApp();
                    cBoxHibernar.Enabled = false;
                    cBoxHours.Enabled = false;
                    cBoxMinuts.Enabled = false;
                    cBoxSeconds.Enabled = false;
                }
                else
                {
                    MessageBox.Show(translateId == 0 ? "Digite o tempo que deseja desligar o PC" : "Enter the time you want to turn off the PC",
                        translateId == 0 ? "Desligar o PC" : "Turn off the PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            else
            {
                shutdownEnable = false;
                Cancel();
                TranslateApp();
                cBoxHibernar.Enabled = true;
                cBoxHours.Enabled = true;
                cBoxMinuts.Enabled = true;
                cBoxSeconds.Enabled = true;
            }
        }

        #region All Check Box
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)//Se a tecla digitada não for número
            {
                e.Handled = true;
            }
        }

        private void cBoxHours_Click(object sender, EventArgs e)//Ativando cada um dos checkbox e desativando os demais
        {
            CkeckBoxChange(0);
        }

        private void cBoxMinuts_Click(object sender, EventArgs e)
        {
            CkeckBoxChange(1);
        }

        private void cBoxSeconds_Click(object sender, EventArgs e)
        {
            CkeckBoxChange(2);
        }

        private void cBoxHibernar_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxHibernar.Checked == true)
            {
                TranslateApp();
            }
            else
            {
                TranslateApp();
            }
        }

        private void CkeckBoxChange(int testeCheck)
        {
            if (testeCheck == 0)
            {
                cBoxHours.Checked = true;
                cBoxMinuts.Checked = false;
                cBoxSeconds.Checked = false;
                textBox1.MaxLength = 1;
            }
            else if (testeCheck == 1)
            {
                cBoxHours.Checked = false;
                cBoxMinuts.Checked = true;
                cBoxSeconds.Checked = false;
                textBox1.MaxLength = 3;
            }
            else
            {
                cBoxHours.Checked = false;
                cBoxMinuts.Checked = false;
                cBoxSeconds.Checked = true;
                textBox1.MaxLength = 5;
            }
            textBox1.Text = "1";
        }

        #endregion

        private void Timer_Tick(object sender, EventArgs e)
        {
            if (clockActive)
            {
                timeCalculate -= 1;
                textBox1.Text = String.Format("{0:#,0#}:{1:#,0#}:{2:#,0#}", (timeCalculate / 3600), ((timeCalculate % 3600) / 60), ((timeCalculate % 3600) % 60));
            }

            if (timeCalculate == 0)
            {
                timer1.Stop();
                if (cBoxHibernar.Checked == true)
                {
                    Hibernar();
                    clockActive = false;
                }
                else
                {
                    Shutdown();
                    clockActive = false;
                }
            }
        }

        private void ClockStart()
        {
            timer1.Interval = 1000;
            textBox1.Enabled = false;
            timer1.Start();
        }


        private void Hibernar()
        {
            WinPower.Execute(WinPower.PowerOption.Hibernate);
        }

        private void Shutdown()
        {
            WinPower.Execute(WinPower.PowerOption.PowerOff);
        }
        
        private void Cancel()
        {
            textBox1.Enabled = true;
            clockActive = false;
            timer1.Stop();
            CkeckBoxChange(0);
            textBox1.Text = "1";
        }

        private void CalculeTime()
        {
            if (cBoxHours.Checked)
            {
                timeCalculate = Convert.ToInt32(textBox1.Text) * 3600;
            }

            else if (cBoxMinuts.Checked)
            {
                timeCalculate = Convert.ToInt32(textBox1.Text) * 60;
            }

            else if (cBoxSeconds.Checked)
            {
                timeCalculate = Convert.ToInt32(textBox1.Text);
                if (timeCalculate < 50)
                {
                    MessageBox.Show((translateId == 0 ? "O computador será desligado em " : "The computer will shut down in ")
                        + timeCalculate + (translateId == 0 ? " segundos" : " seconds"), 
                        (translateId == 0 ? "Desligar o PC" : "Shut down the PC") , MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
            }
            clockActive = true;
            ClockStart();
        }

        public void TranslateApp()
        {
            portugueseMenuItem.Checked = translateId == 0 ? true : false;
            englishMenuItem.Checked = translateId == 0 ? false : true;
            ActiveForm.Text = translateId == 0 ? "Desligando PC" : "Turn off PC";
            fileMenuItem.Text = translateId == 0 ? "Arquivo" : "File";
            aboultMenuItem.Text = translateId == 0 ? "Sobre" : "About";
            exitMenuItem.Text = translateId == 0 ? "Sair" : "Exit";
            actionMenuItem.Text = translateId == 0 ? "Ação" : "Action";
            rebootMenuItem.Text = translateId == 0 ? "Reiniciar Agora" : "Reboot Now";
            hibernateMenuItem.Text = translateId == 0 ? "Hibernar Agora" : "Hibernate Now";
            languageMenuItem.Text = translateId == 0 ? "Idioma" : "Language";
            portugueseMenuItem.Text = translateId == 0 ? "Português" : "Portuguese";
            englishMenuItem.Text = translateId == 0 ? "Inglês" : "English";
            cBoxHours.Text = translateId == 0 ? "Horas" : "Hours";
            cBoxMinuts.Text = translateId == 0 ? "Minutos" : "Minutes";
            cBoxSeconds.Text = translateId == 0 ? "Segundos": "Seconds";
            label1.Location = new System.Drawing.Point(translateId == 0 ? 161 : 135, 175);
            cBoxHibernar.Text = translateId == 0 ? "Hibernar" : "Hibernate";

            if (!shutdownEnable)
            {
                if (cBoxHibernar.Checked == true)
                {
                    label1.Text = translateId == 0 ? "Tempo para hibernar" : "Time to hibernate equipment";
                    button1.Text = translateId == 0 ? "Hibernar PC" : "Hibernate PC";
                }
                else
                {
                    label1.Text = translateId == 0 ? "Tempo para desligar" : "Time to turn off equipment";
                    button1.Text = translateId == 0 ? "Desligar PC" : "Turn off PC";
                }
            }
            else
            {
                if (cBoxHibernar.Checked == true)
                {
                    label1.Text = translateId == 0 ? "Tempo para hibernar" : "Time to hibernate equipment";
                    button1.Text = translateId == 0 ? "Cancelar" : "Cancel";
                }
                else
                {
                    label1.Text = translateId == 0 ? "Tempo para desligar" : "Time to turn off equipment";
                    button1.Text = translateId == 0 ? "Cancelar" : "Cancel";
                }
            }
        }
    }
}