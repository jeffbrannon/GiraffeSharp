using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using GiraffeSharp.ViewModels;
using GiraffeSharp.Views;

namespace GiraffeSharp
{
    public class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                desktop.MainWindow = new MainWindow
                {
                    DataContext = new CodeListViewModel(),
                };
            }

            base.OnFrameworkInitializationCompleted();
        }
    }
}
