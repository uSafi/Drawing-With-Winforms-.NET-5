using System;
using System.Windows.Forms;

namespace Drawing_With_Winforms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.Run(new Dashboard());
        }
    }
}