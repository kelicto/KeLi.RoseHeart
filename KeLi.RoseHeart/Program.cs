﻿using System;
using System.Windows.Forms;

using KeLi.RoseHeart.Forms;

namespace KeLi.RoseHeart
{
    public static class Program
    {
        [STAThread]
        public static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}