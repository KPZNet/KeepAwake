using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

using System.Threading;


namespace KSaver
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool firstInstance;
            Mutex mutex = new Mutex(false, "Local\\" + "KeepAwake10928304327", out firstInstance);
            if (firstInstance == true)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new KeepAwakeMainForm());
            }
            GC.KeepAlive(mutex); 
        }
    }
}
