using System.Diagnostics;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;

namespace ControlDevelopLearning
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }

        private void ClickablePanel_OnClick(object? sender, RoutedEventArgs e)
        {
            Debug.WriteLine("Panel got click! Handled event from it");
            e.Handled = true;
        }
    }
}