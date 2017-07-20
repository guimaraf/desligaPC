using System;
using System.Windows.Forms;

namespace DesligandoPC
{
    public partial class FormSobre : Form
    {

        public FormSobre()
        {
            InitializeComponent();
        }

        public void TraduzirApp(string lingua)
        {
            if (lingua == "portugues")
            {
                FormSobre.ActiveForm.Text = "Sobre";
                lblNome.Text = "Desenvolvido por Frederico Oliveira";
                lblNome.Location = new System.Drawing.Point(93,47);
                lblContato.Text = "Contato: guimaraf@gmail.com";
                lblDownload.Text = "Download código fonte";
            }
            else
            {
                FormSobre.ActiveForm.Text = "About";
                lblNome.Text = "Developed Frederico Oliveira";
                lblNome.Location = new System.Drawing.Point(118, 47);
                lblContato.Text = "Contact: guimaraf@gmail.com";
                lblDownload.Text = "Download souce code";
            }
        }

        private void FormSobre_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form1 formularioPadrao = new Form1();
            formularioPadrao.Show();
        }

        
    }
}
