using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GiraffeSharp.ViewModels;

namespace GiraffeSharp.Views
{
    public partial class CodeView : UserControl
    {
        public CodeView()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            DataContext = new CodeListViewModel();
        }
    }
}
