using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace GiraffeSharp.Views
{
    public partial class CodeEditor : UserControl
    {
        public CodeEditor()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
