using Jamesnet.Wpf.Controls;
using System.Windows;

namespace WpfExplorer
{
    internal class App : JamesApplication
    {
        protected override Window CreateShell()
        {
            //Temporary Window instance
            return new Window();
        }
    }
}
