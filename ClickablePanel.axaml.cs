using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Markup.Xaml;
using Avalonia.Media;

namespace ControlDevelopLearning;

public partial class ClickablePanel : UserControl
{
    private Panel _rootPanel;
    
    public ClickablePanel()
    {
        InitializeComponent();
    }

    private void InitializeComponent() => AvaloniaXamlLoader.Load(this);

    public static readonly StyledProperty<IBrush> TextForegroundProperty =
        AvaloniaProperty.Register<ClickablePanel, IBrush>(nameof(TextForeground), Brushes.Black, true);

    public IBrush TextForeground
    {
        get => GetValue(TextForegroundProperty);
        set => SetValue(TextForegroundProperty, value);
    }

    protected override void OnApplyTemplate(TemplateAppliedEventArgs e)
    {
        base.OnApplyTemplate(e);
        _rootPanel = this.FindControl<Panel>("PART_RootPanel");
    }
}