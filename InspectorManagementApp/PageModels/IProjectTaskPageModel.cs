using CommunityToolkit.Mvvm.Input;
using InspectorManagementApp.Models;

namespace InspectorManagementApp.PageModels
{
    public interface IProjectTaskPageModel
    {
        IAsyncRelayCommand<ProjectTask> NavigateToTaskCommand { get; }
        bool IsBusy { get; }
    }
}