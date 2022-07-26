using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Primitives;
using Avalonia.Interactivity;
using Avalonia.Media;

namespace ControlDevelopLearning;

public partial class ClickablePanel : UserControl
{
    private Panel _rootPanel;

    public static readonly RoutedEvent<RoutedEventArgs> ClickEvent =
        RoutedEvent.Register<ClickablePanel, RoutedEventArgs>(nameof(Click), RoutingStrategies.Bubble);

    public static readonly StyledProperty<IBrush> TextForegroundProperty =
        AvaloniaProperty.Register<ClickablePanel, IBrush>(nameof(TextForeground), Brushes.Black, true);

    public event EventHandler<RoutedEventArgs> Click
    {
        add => AddHandler(ClickEvent, value);
        remove => RemoveHandler(ClickEvent, value);
    }

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