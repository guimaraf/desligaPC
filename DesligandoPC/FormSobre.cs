using System;
using System.Windows.Forms;

namespace DesligandoPC
{
    public partial class FormSobre : Form
    {
        public string linguaNovoFormulario = "";
        Form1 formularioPadrao = new Form1();
        public FormSobre()
        {
            InitializeComponent();
        }

        public void TraduzirApp(string lingua)
        {
            linguaNovoFormulario = lingua;
            if (lingua == "portugues")
            {
                lblVersao.Text = "DesligaPC versão " + formularioPadrao.versao;
                lblVersao.Location = new System.Drawing.Point(151,22);
                FormSobre.ActiveForm.Text = "Sobre";
                lblNome.Text = "Desenvolvido por Frederico Oliveira";
                lblNome.Location = new System.Drawing.Point(93,47);
                lblContato.Text = "Contato: guimaraf@gmail.com";
                lblDownload.Text = "Download código fonte";
            }
            else
            {
                lblVersao.Text = "ShutdownPC version " + formularioPadrao.versao;
                lblVersao.Location = new System.Drawing.Point(145, 22);
                FormSobre.ActiveForm.Text = "About";
                lblNome.Text = "Developed Frederico Oliveira";
                lblNome.Location = new System.Drawing.Point(118, 47);
                lblContato.Text = "Contact: guimaraf@gmail.com";
                lblDownload.Text = "Download souce code";
            }
        }

        private void FormSobre_FormClosed(object sender, FormClosedEventArgs e)
        {
            
            formularioPadrao.Show();
            formularioPadrao.traducaoApp(linguaNovoFormulario);
        }
    }
}
