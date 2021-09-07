using Avalonia;
using Avalonia.Interactivity;
using System.Collections.Generic;

namespace RTI_CrossPlatformWTRTIInterface
{
    class Program
    {        
        public static void Main(string[] args) 
            => BuildAvaloniaApp()
                .StartWithClassicDesktopLifetime(args);

        public static AppBuilder BuildAvaloniaApp()
            => AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .LogToTrace();
    }
}
