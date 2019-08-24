using System.Windows.Forms;

namespace DesligandoPC
{
    public partial class FormSobre : Form
    {
        Form1 form = new Form1();
        public FormSobre()
        {
            InitializeComponent();
        }

        public void TranslateApp(int translateId)
        {
            lblVersion.Text = translateId == 0 ? "DesligaPC versão " + form.version : "ShutdownPC version " + form.version;
            lblVersion.Location = new System.Drawing.Point(translateId == 0 ? 151 : 145, 22);
            FormSobre.ActiveForm.Text = translateId == 0 ? "Sobre" : "About";
            lblName.Text = translateId == 0 ? "Desenvolvido por Frederico Oliveira" : "Developed Frederico Oliveira";
            lblName.Location = new System.Drawing.Point(translateId == 0 ? 93 : 118, 47);
            lblContact.Text = translateId == 0 ? "Contato: guimaraf@gmail.com" : "Contact: guimaraf@gmail.com";
            lblDownload.Text = translateId == 0 ? "Download código fonte" : "Download souce code";
        }

        private void FormSobre_FormClosed(object sender, FormClosedEventArgs e)
        {
            form.Show();
        }
    }
}
