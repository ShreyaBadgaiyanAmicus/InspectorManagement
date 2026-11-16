using InspectorManagementApp.Models;

#if WINDOWS
using InspectorManagementApp.Behaviors;
#endif

namespace InspectorManagementApp.Pages
{
    public partial class ProjectDetailPage : ContentPage
    {
        public ProjectDetailPage(ProjectDetailPageModel model)
        {
            InitializeComponent();

            BindingContext = model;
#if WINDOWS
    		ProjectTasksCollectionView.Behaviors.Add(new SingleSelectionKeyboardGuardBehavior());
    		IconsCollectionView.Behaviors.Add(new SingleSelectionKeyboardGuardBehavior());
#endif
        }
    }
}
