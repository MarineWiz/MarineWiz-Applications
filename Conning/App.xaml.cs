using System;
using System.Windows;
using System.Collections.Generic;
using System.Windows.Threading;
using System.Runtime.InteropServices;

namespace App_Conning
{
    public partial class App : Application
    {
    	[DllImport("kernel32.dll")]
        static extern IntPtr GetConsoleWindow();

        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);

        const int SW_HIDE = 0;
        
        public App()
        {
			var handle = GetConsoleWindow();
            ShowWindow(handle, SW_HIDE);
        }
    }
}