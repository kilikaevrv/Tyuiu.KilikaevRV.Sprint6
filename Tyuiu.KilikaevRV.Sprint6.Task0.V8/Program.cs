using System;
using System.Windows.Forms;

namespace Tyuiu.KilikaevRV.Sprint6.Task0.V8
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());
        }
    }
}