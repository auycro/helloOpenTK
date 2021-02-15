using Gtk;

namespace helloOpenTK
{
    public class MainWindow : Window
    {
      public MainWindow() : this(new Builder("MainWindow.glade")) { }

      public MainWindow(Builder builder) : base(builder.GetObject("MainWindow").Handle)
      {
        builder.Autoconnect(this);
      }
    }
}