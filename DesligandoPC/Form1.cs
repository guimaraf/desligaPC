using System;
using System.Windows.Forms;

namespace DesligandoPC
{
    public partial class Form1 : Form
    {
        private int tempoCalcular = 0;
        private string versao = "1.2";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program clicado = new Program();
            if (textBox1.TextLength > 0)
            {
                if (cBoxHours.Checked) //Horas
                {
                    tempoCalcular = Convert.ToInt32(textBox1.Text) * 3600;
                    clicado.desligarPC(Convert.ToString(tempoCalcular));
                }

                else if (cBoxMinuts.Checked) //Minutos
                {
                    tempoCalcular = Convert.ToInt32(textBox1.Text) * 60;
                    clicado.desligarPC(Convert.ToString(tempoCalcular));
                }

                else if (cBoxSeconds.Checked) //Segundos
                {
                    tempoCalcular = Convert.ToInt32(textBox1.Text);
                    if (tempoCalcular < 50)
                    {
                        if(portugêsToolStripMenuItem.Checked == true)
                        {
                            MessageBox.Show("O computador será desligado em " + tempoCalcular + " segundos", "Desligar o PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            clicado.desligarPC(Convert.ToString(tempoCalcular));
                        }
                        else
                        {
                            MessageBox.Show("The computer will shut down in " + tempoCalcular + " seconds", "Shut down the PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            clicado.desligarPC(Convert.ToString(tempoCalcular));
                        }
                        
                    }
                    else
                    {
                        clicado.desligarPC(Convert.ToString(tempoCalcular));
                    }
                }
                //Mostrar mensagem alerta para o usuário
            }
            else
            {
                if (portugêsToolStripMenuItem.Checked == true)
                {
                    MessageBox.Show("Digite o tempo que deseja desligar o PC", "Desligar o PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                else
                {
                    MessageBox.Show("Enter the time you want to turn off the PC", "Turn off the PC", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se a tecla digitada não for número
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {
                //Atribui True no Handled para cancelar o evento
                e.Handled = true;
            }
        }
        //Ativando cada um dos checkbox e desativando os demais
        private void cBoxHours_Click(object sender, EventArgs e)
        {
            cBoxHours.Checked = true;
            cBoxMinuts.Checked = false;
            cBoxSeconds.Checked = false;
        }

        private void cBoxMinuts_Click(object sender, EventArgs e)
        {
            cBoxHours.Checked = false;
            cBoxMinuts.Checked = true;
            cBoxSeconds.Checked = false;
        }

        private void cBoxSeconds_Click(object sender, EventArgs e)
        {
            cBoxHours.Checked = false;
            cBoxMinuts.Checked = false;
            cBoxSeconds.Checked = true;
        }
        
        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(portugêsToolStripMenuItem.Checked == true)
            {
                MessageBox.Show("Aplicativo desenvolvido por Frederico Oliveira\nVersão "+versao+"\n\nContato \nEmail: guimaraf@gmail\nWhatsapp: 55 31 99368-4011", "Sobre", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                MessageBox.Show("Aplication developed by Frederico Oliveira\nVersion " + versao + "\n\nContact \nEmail: guimaraf@gmail\nWhatsapp: 55 31 99368-4011", "About", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void cancelarDesligamentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-a");
        }

        private void reiniciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-r -t 10");
        }

        private void portugêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            portugêsToolStripMenuItem.Checked = true;
            inglêsToolStripMenuItem.Checked = false;
            Form1.ActiveForm.Text = "Desligando PC";
            arquivoToolStripMenuItem.Text = "Arquivo";
            sobreToolStripMenuItem.Text = "Sobre";
            sairToolStripMenuItem.Text = "Sair";
            açãoToolStripMenuItem.Text = "Ação";
            cancelarDesligamentoToolStripMenuItem.Text = "Cancelar desligamento";
            reiniciarToolStripMenuItem.Text = "Reiniciar";
            hibernarToolStripMenuItem.Text = "Hibernar";
            idiomaToolStripMenuItem.Text = "Linguagem";
            portugêsToolStripMenuItem.Text = "Português";
            inglêsToolStripMenuItem.Text = "Inglês";
            cBoxHours.Text = "Horas";
            cBoxMinuts.Text = "Minutos";
            cBoxSeconds.Text = "Segundos";
            label1.Text = "Tempo para desligar";
            label1.Location = new System.Drawing.Point(133, 124);
            button1.Text = "Desligar PC";
        }

        private void inglêsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            portugêsToolStripMenuItem.Checked = false;
            inglêsToolStripMenuItem.Checked = true;
            Form1.ActiveForm.Text = "Turn off PC";
            arquivoToolStripMenuItem.Text = "File";
            sobreToolStripMenuItem.Text = "About";
            sairToolStripMenuItem.Text = "Exit";
            açãoToolStripMenuItem.Text = "Action";
            cancelarDesligamentoToolStripMenuItem.Text = "Cancel shutdown";
            reiniciarToolStripMenuItem.Text = "Reboot";
            hibernarToolStripMenuItem.Text = "Hibernate";
            idiomaToolStripMenuItem.Text = "Language";
            portugêsToolStripMenuItem.Text = "Portuguese";
            inglêsToolStripMenuItem.Text = "English";
            cBoxHours.Text = "Hours";
            cBoxMinuts.Text = "Minutes";
            cBoxSeconds.Text = "Seconds";
            label1.Text = "Time to turn off equipment";
            label1.Location = new System.Drawing.Point(110, 124);
            button1.Text = "Turn off PC";

        }

        private void hibernarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("shutdown", "-h");
        }
    }
}