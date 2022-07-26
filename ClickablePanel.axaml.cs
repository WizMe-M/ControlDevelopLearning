using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace ControlDevelopLearning;

public partial class ClickablePanel : UserControl
{
    public ClickablePanel()
    {
        InitializeComponent();
    }

    private void InitializeComponent()
    {
        AvaloniaXamlLoader.Load(this);
    }
}