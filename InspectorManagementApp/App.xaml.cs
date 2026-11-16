
using System.Diagnostics;

namespace InspectorManagementApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            Window window = new Window(new AppShell());

            window.Created += (sender, args) =>
                Debug.WriteLine("Lifecycle Event: Created");

            window.Activated += (sender, args) =>
                Debug.WriteLine("Lifecycle Event: Activated");

            window.Deactivated += (sender, args) =>
                Debug.WriteLine("Lifecycle Event: Deactivated");

            window.Stopped += (sender, args) =>
                Debug.WriteLine("Lifecycle Event: Stopped");

            window.Resumed += (sender, args) =>
                Debug.WriteLine("Lifecycle Event: Resumed");

            window.Destroying += (sender, args) =>
                Debug.WriteLine("Lifecycle Event: Destroying");

            return window;
        }
    }
}
