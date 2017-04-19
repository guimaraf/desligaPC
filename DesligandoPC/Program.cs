using System;
using System.Windows.Forms;

namespace DesligandoPC
{
    class Program
    {
 
        //public string tempo = "60";

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public void desligarPC(string tempoDesligar)
        {
            System.Diagnostics.Process.Start("shutdown", "-s -t " + tempoDesligar);
        }
    }
}