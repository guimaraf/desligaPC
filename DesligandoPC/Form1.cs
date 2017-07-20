using System;
using System.Windows.Forms;

namespace DesligandoPC
{
    [Serializable]
    public partial class Form1 : Form
    {
        private int tempoCalcular = 0;
        public string versao = "1.5", linguagem = "portugues";
        private bool relogioFunciona = false, podeDesligar = false;

        public Form1()
        {
            InitializeComponent();
            
        }

        //Botões//
        private void button1_Click(object sender, EventArgs e)
        {
            if (!podeDesligar)
            {
                if (textBox1.TextLength > 0)
                {
                    podeDesligar = true;
                    calcularTempo();
                    traducaoApp(linguagem);
                    cBoxHibernar.Enabled = false;
                    cBoxHours.Enabled = false;
                    cBoxMinuts.Enabled = false;
                    cBoxSeconds.Enabled = false;
                }
                else
                {
                    if (linguagem == "portugues")
                    {
                        MessageBox.Show("Digite o tempo que deseja desligar o PC", "Desligar o PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("Enter the time you want to turn off the PC", "Turn off the PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            else
            {
                podeDesligar = false;
                Cancelar();
                traducaoApp(linguagem);
                cBoxHibernar.Enabled = true;
                cBoxHours.Enabled = true;
                cBoxMinuts.Enabled = true;
                cBoxSeconds.Enabled = true;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)//Se a tecla digitada não for número
            {
                e.Handled = true;
            }
        }
        
        private void cBoxHours_Click(object sender, EventArgs e)//Ativando cada um dos checkbox e desativando os demais
        {
            trocarCkeckBox(0);
        }

        private void cBoxMinuts_Click(object sender, EventArgs e)
        {
            trocarCkeckBox(1);
        }

        private void cBoxSeconds_Click(object sender, EventArgs e)
        {
            trocarCkeckBox(2);
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)//Trocar idioma
        {
            FormSobre novoFormulario = new FormSobre();
            novoFormulario.Show();
            novoFormulario.TraduzirApp(linguagem);
            this.Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)//Fechar o programa
        {
            Application.Exit();
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)//Reiniciar direto
        {
            System.Diagnostics.Process.Start("shutdown", "-r -t 10");
        }

        private void hibernarToolStripMenuItem_Click(object sender, EventArgs e)//Hibernar direto
        {
            System.Diagnostics.Process.Start("shutdown", "-h");
        }

        private void portugêsToolStripMenuItem_Click(object sender, EventArgs e)//Tradução português
        {
            linguagem = "portugues";
            traducaoApp(linguagem);
        }

        private void inglêsToolStripMenuItem_Click(object sender, EventArgs e)//Tradução Inglês
        {
            linguagem = "ingles";
            traducaoApp(linguagem);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (relogioFunciona)
            {
                tempoCalcular -= 1;
                //textBox1.Text = Convert.ToString(tempoCalcular);

                textBox1.Text = String.Format("{0:#,0#}:{1:#,0#}:{2:#,0#}", (tempoCalcular / 3600), ((tempoCalcular % 3600) / 60), ((tempoCalcular % 3600) % 60));
            }
            
            if(tempoCalcular == 0)//Finalizando o contador
            {
                timer1.Stop();
                //relogioFunciona = false;

                if (cBoxHibernar.Checked == true)
                {
                    hibernar();
                    relogioFunciona = false;
                }
                else
                {
                    desligar();
                    relogioFunciona = false;
                }
            }
        }

        private void cBoxHibernar_CheckedChanged(object sender, EventArgs e)//Ao clicar no hibertar, vai também mudar os textos
        {
            if (cBoxHibernar.Checked == true)
            {
                traducaoApp(linguagem);
            }
            else
            {
                traducaoApp(linguagem);
            }
        }

        //Funções//

        private void trocarCkeckBox(int testeCheck)//Joguei dentro de uma função para poder reaproveitar o código
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

        private void RodarComando()//Ativa o relógio
        {
            timer1.Interval = 1000;
            textBox1.Enabled = false;
            timer1.Start();
        }


        private void hibernar()
        {
            //System.Diagnostics.Process.Start("shutdown", "-h");
            Application.SetSuspendState(PowerState.Hibernate, false, false);
        }

        private void desligar()
        {
            System.Diagnostics.Process.Start("shutdown", "-s -t " + 0);
        }
        
        private void Cancelar()//Cancelar tempo de desligamento
        {
            textBox1.Enabled = true;
            relogioFunciona = false;
            timer1.Stop();
            trocarCkeckBox(0);
            textBox1.Text = "1";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void calcularTempo()
        {
            if (cBoxHours.Checked) //Horas
            {
                tempoCalcular = Convert.ToInt32(textBox1.Text) * 3600;
            }

            else if (cBoxMinuts.Checked) //Minutos
            {
                tempoCalcular = Convert.ToInt32(textBox1.Text) * 60;
            }

            else if (cBoxSeconds.Checked) //Segundos
            {
                tempoCalcular = Convert.ToInt32(textBox1.Text);
                if (tempoCalcular < 50)
                {
                    if (portugêsToolStripMenuItem.Checked == true)
                    {
                        MessageBox.Show("O computador será desligado em " + tempoCalcular + " segundos", "Desligar o PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                    else
                    {
                        MessageBox.Show("The computer will shut down in " + tempoCalcular + " seconds", "Shut down the PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    }
                }
            }
            relogioFunciona = true;
            RodarComando();
        }
       
        private void traducaoApp(string lingua)
        {
            if (lingua == "portugues")
            {
                portugêsToolStripMenuItem.Checked = true;
                inglêsToolStripMenuItem.Checked = false;
                Form1.ActiveForm.Text = "Desligando PC";
                arquivoToolStripMenuItem.Text = "Arquivo";
                sobreToolStripMenuItem.Text = "Sobre";
                sairToolStripMenuItem.Text = "Sair";
                açãoToolStripMenuItem.Text = "Ação";
                reiniciarToolStripMenuItem.Text = "Reiniciar Agora";
                hibernarToolStripMenuItem.Text = "Hibernar Agora";
                idiomaToolStripMenuItem.Text = "Linguagem";
                portugêsToolStripMenuItem.Text = "Português";
                inglêsToolStripMenuItem.Text = "Inglês";
                cBoxHours.Text = "Horas";
                cBoxMinuts.Text = "Minutos";
                cBoxSeconds.Text = "Segundos";
                label1.Location = new System.Drawing.Point(161, 175);
                cBoxHibernar.Text = "Hibernar";

                if (!podeDesligar)
                {
                    if (cBoxHibernar.Checked == true)
                    {
                        label1.Text = "Tempo para hibernar";
                        button1.Text = "Hibernar PC";
                    }
                    else
                    {
                        button1.Text = "Desligar PC";
                        label1.Text = "Tempo para desligar";
                    }
                }
                else
                {
                    if (cBoxHibernar.Checked == true)
                    {
                        button1.Text = "Cancelar";
                        label1.Text = "Tempo para hibernar";
                    }
                    else
                    {
                        button1.Text = "Cancelar";
                        label1.Text = "Tempo para desligar";
                    }
                    
                }
            }
            else
            {
                portugêsToolStripMenuItem.Checked = false;
                inglêsToolStripMenuItem.Checked = true;
                Form1.ActiveForm.Text = "Turn off PC";
                arquivoToolStripMenuItem.Text = "File";
                sobreToolStripMenuItem.Text = "About";
                sairToolStripMenuItem.Text = "Exit";
                açãoToolStripMenuItem.Text = "Action";
                reiniciarToolStripMenuItem.Text = "Reboot Now";
                hibernarToolStripMenuItem.Text = "Hibernate Now";
                idiomaToolStripMenuItem.Text = "Language";
                portugêsToolStripMenuItem.Text = "Portuguese";
                inglêsToolStripMenuItem.Text = "English";
                cBoxHours.Text = "Hours";
                cBoxMinuts.Text = "Minutes";
                cBoxSeconds.Text = "Seconds";
                label1.Location = new System.Drawing.Point(135, 175);
                cBoxHibernar.Text = "Hibernate";

                if (!podeDesligar)
                {
                    if (cBoxHibernar.Checked == true)
                    {
                        button1.Text = "Hibernate PC";
                        label1.Text = "Time to hibernate equipment";
                    }
                    else
                    {
                        button1.Text = "Turn off PC";
                        label1.Text = "Time to turn off equipment";
                    }
                }
                else
                {
                    if (cBoxHibernar.Checked == true)
                    {
                        button1.Text = "Cancel";
                        label1.Text = "Time to hibernate equipment";
                    }
                    else
                    {
                        button1.Text = "Cancel";
                        label1.Text = "Time to turn off equipment";
                    }
                }
            }
        }
    }
}