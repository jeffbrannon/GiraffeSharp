using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using GiraffeSharp.ViewModels;

namespace GiraffeSharp.Views
{
    public partial class CodeViewItem : UserControl
    {
        public string CodeListItem { get; set; }
        public CodeViewItem()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            DataContext = CodeListItem;
        }
    }
}
