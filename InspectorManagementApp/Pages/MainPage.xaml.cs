using InspectorManagementApp.Models;
using InspectorManagementApp.PageModels;

#if WINDOWS
using InspectorManagementApp.Behaviors;
#endif

namespace InspectorManagementApp.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage(MainPageModel model)
        {
            InitializeComponent();
            BindingContext = model;
#if WINDOWS
    		ProjectsCollectionView.Behaviors.Add(new SingleSelectionKeyboardGuardBehavior());
    		TasksCollectionView.Behaviors.Add(new SingleSelectionKeyboardGuardBehavior());
#endif
        }
    }
}
