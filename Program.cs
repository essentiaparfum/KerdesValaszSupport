using System;
using System.Windows.Forms;

namespace KerdesValaszSupport
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());    // Form1 ind�t�sa
        }
    }
}
