#if WINDOWS
using InspectorManagementApp.Behaviors;
#endif
namespace InspectorManagementApp.Pages
{
    public partial class ProjectListPage : ContentPage
    {
        public ProjectListPage(ProjectListPageModel model)
        {
            BindingContext = model;
            InitializeComponent();
#if WINDOWS
    		ProjectsCollectionView.Behaviors.Add(new SingleSelectionKeyboardGuardBehavior());
#endif
        }
    }
}
