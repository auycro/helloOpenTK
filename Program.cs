//using System;
using Gtk;
using OpenTK;

namespace helloOpenTK
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            Toolkit.Init(new ToolkitOptions
            {
                Backend = PlatformBackend.PreferNative
            });

            // Initialize Gtk.
            Application.Init();

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();

            Application.Run();
        }
    }
}
