
using System.Collections.ObjectModel;
using InspectorManagementApp.Models;

namespace InspectorManagementApp.Pages;

public partial class InspectionListPage : ContentPage
{
    public ObservableCollection<Inspection> Inspections { get; set; }

    public Inspection? SelectedInspection { get; set; }

    public InspectionListPage()
    {
        InitializeComponent();

        Inspections = new ObservableCollection<Inspection>
        {
            new Inspection
            {
                Title = "Factory Safety Inspection",
                Site = "Industrial Area, Building A",
                Status = "Pending",
                ScheduledDate = new DateTime(2026, 11, 17)
            },
            new Inspection
            {
                Title = "Equipment Quality Check",
                Site = "Manufacturing Unit 2",
                Status = "In Progress",
                ScheduledDate = new DateTime(2026, 11, 17)
            },
            new Inspection
            {
                Title = "Building Compliance Review",
                Site = "Office Complex",
                Status = "Completed",
                ScheduledDate = new DateTime(2026, 11, 18)
            },
            new Inspection
            {
                Title = "Fire Safety Inspection",
                Site = "Warehouse Block B",
                Status = "Pending",
                ScheduledDate = new DateTime(2026, 11, 18)
            },
            new Inspection
            {
                Title = "Electrical Safety Audit",
                Site = "Production Unit 1",
                Status = "In Progress",
                ScheduledDate = new DateTime(2026, 11, 19)
            },
            new Inspection
            {
                Title = "Environmental Assessment",
                Site = "Chemical Plant",
                Status = "Completed",
                ScheduledDate = new DateTime(2026, 11, 19)
            },
            new Inspection
            {
                Title = "Machine Maintenance Review",
                Site = "Assembly Section",
                Status = "Pending",
                ScheduledDate = new DateTime(2026, 11, 20)
            },
            new Inspection
            {
                Title = "Workplace Health Inspection",
                Site = "Corporate Office",
                Status = "In Progress",
                ScheduledDate = new DateTime(2026, 11, 21)
            },
            new Inspection
            {
                Title = "Storage Facility Audit",
                Site = "Storage Unit 3",
                Status = "Completed",
                ScheduledDate = new DateTime(2026, 11, 22)
            },
            new Inspection
            {
                Title = "Fire Equipment Verification",
                Site = "Emergency Equipment Room",
                Status = "Pending",
                ScheduledDate = new DateTime(2026, 11, 23)
            }
        };

        BindingContext = this;
    }
}
