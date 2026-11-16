
namespace InspectorManagementApp.Pages.Controls;

public partial class StatusBadge : ContentView
{
    public static readonly BindableProperty StatusProperty =
        BindableProperty.Create(
            nameof(Status),
            typeof(string),
            typeof(StatusBadge),
            "Pending");

    public string Status
    {
        get => (string)GetValue(StatusProperty);
        set => SetValue(StatusProperty, value);
    }

    public StatusBadge()
    {
        InitializeComponent();
    }
}
