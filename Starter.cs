﻿using System;

namespace WpfExplorer
{
    internal class Starter
    {
        [STAThread]
        private static void Main(string[] args)
        {
            _ = new App().Run();
        }
    }
}
