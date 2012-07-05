﻿using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace DojoTimer
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
			Mono.Unix.Catalog.Init ("DojoTimer", "./locale");
            Application.Run(new MainForm());
        }
    }
}
