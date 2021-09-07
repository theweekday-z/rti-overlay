using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace RTI_CrossPlatformWTRTIInterface
{
    public partial class MainWindow : Window
    {
        List<string> varOrder = new List<string>();

        public void varChecked(object sender, RoutedEventArgs eventArgs) => varOrder.Insert(0, sender.ToString());
        public void varUnchecked(object sender, RoutedEventArgs eventArgs) => varOrder.Remove(sender.ToString());

        public void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);

#if DEBUG
            this.AttachDevTools();
#endif
        }

        public MainWindow() => InitializeComponent();
    }
}
