# Assignment 1

## 1. Create a new .NET MAUI application (single project). In the README, explain the project structure in your own words: which files are shared by all platforms, what the Platforms folder contains, and which file starts the app. Run the app on the Android Emulator, and on the iOS Simulator as well where a Mac is available.

### Inspector Management App

#### 1. Project Overview

Inspector Management App is a cross-platform application developed using **.NET MAUI 11, C# and XAML**.

.NET MAUI allows us to create applications for Android, iOS, macOS and Windows using a single shared project. This means we can reuse most of our code and UI across different platforms instead of creating separate projects for each operating system.

#### 2. Project Structure

This project follows the **.NET MAUI Single Project** architecture. The project is organized into shared files and folders, along with a separate Platforms folder for operating-system-specific code.

##### Shared Files

The following files are used across all supported platforms:

| File | Description |
|---|---|
| `App.xaml` | Contains application-level resources and shared styles. |
| `App.xaml.cs` | Initializes the main MAUI application instance. |
| `AppShell.xaml` | Defines the application's navigation structure. |
| `AppShell.xaml.cs` | Contains the code-behind for AppShell. |
| `MauiProgram.cs` | Configures the application, registers services and dependencies, and builds the MAUI app. |
| `GlobalUsings.cs` | Contains global namespace imports used throughout the project. |

### Shared Folders

- **Behavior:** Contains reusable UI behaviors.
- **Data:** Contains data-related classes.
- **Models:** Contains application data models.
- **PageModels:** Contains presentation logic related to application pages.
- **Pages:** Contains the different screens of the application.
- **Services:** Contains reusable services and application functionality.
- **Utilities:** Contains helper classes and utility methods.
- **Resources:** Contains shared application resources such as fonts, images, icons, splash screens and styles.

### Platforms Folder

The Platforms folder contains code and configuration specific to each operating system supported by .NET MAUI.

It contains the following folders:

| Folder | Description |
|---|---|
| `Android` | Contains Android-specific files such as MainActivity.cs, MainApplication.cs and AndroidManifest.xml. |
| `iOS` | Contains iOS-specific application startup and configuration files. |
| `MacCatalyst` | Contains files required to run the application on macOS using Mac Catalyst. |
| `Windows` | Contains Windows-specific application startup and configuration files. |

These platform-specific files allow us to handle operating-system requirements while keeping most of the application code shared.

##### Important Android Files

- **MainActivity.cs:** Defines the Android activity that hosts the MAUI application. The `MainLauncher = true` attribute identifies it as the application's launch activity.
- **MainApplication.cs:** Inherits from `MauiApplication` and initializes the MAUI application by calling `MauiProgram.CreateMauiApp()`.
- **AndroidManifest.xml:** Contains Android application settings, application icon configuration and permissions such as Internet and network-state access.

#### 3. Application Startup

The application starts through its platform-specific entry point.

For Android, the startup process works as follows:

1. `MainActivity.cs` acts as the Android launcher activity.
2. `MainApplication.cs` initializes the MAUI application.
3. `MauiProgram.cs` configures and builds the application.
4. `App.xaml.cs` creates the application instance.
5. `AppShell.xaml` defines the navigation structure and initial page.

**MauiProgram.cs** is the central configuration and application-building file, while the actual platform-specific entry point starts the application.

#### 4. Application Execution

| Configuration | Details |
|---|---|
| Framework | .NET 11 |
| Programming Language | C# |
| UI Technology | XAML |
| IDE | Visual Studio 2026 |
| Emulator | Google Pixel 9 Pro |
| Android Version | Android 16 (API 36) |

The application was successfully built and launched on the Google Pixel 9 Pro Android Emulator.

iOS Simulator testing requires a Mac with Xcode installed. It can also be performed from Visual Studio on Windows using a paired Mac.


![Inspector Management App running on Android Emulator](Screenshots/Assignment1/task1.png)


## 2. Log a message in each application lifecycle event of your app (for example Created, Activated, Deactivated, Stopped). Run the app, press the Home button, return to it, and close it. Document in a comment block the order in which the events fired and what you would use each one for in a real app.

``` cs

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
```

![Inspector Management App running on Android Emulator](Screenshots/Assignment1/task2.png)

## 3. Create InspectorProfilePage in XAML showing a photo (Image), name, employee ID, role, email and phone, and an Edit button. No wireframe is given, so you design the layout using VerticalStackLayout and HorizontalStackLayout.

![Inspector Management App running on Android Emulator](Screenshots/Assignment1/task3.png)


## 4. Make sure no content is hidden behind the notch, status bar or home indicator. Document what you did to handle the safe area and why it was needed.


### Safe Area Handling

The InspectorProfilePage uses the `SafeAreaEdges="All"` property
on its ContentPage to keep the content within the device's safe
display area.

This prevents important UI elements from overlapping with:
- The status bar at the top.
- The notch or Dynamic Island on supported iPhones.
- The home indicator at the bottom.

Safe area handling is necessary because mobile devices have
different screen shapes and system UI areas. It improves content
visibility, accessibility and the overall user experience.


## 5. Create DashboardPage using a Grid: four summary cards (Total, Pending, In Progress, Completed) with hardcoded counts for now, and a 'Today's inspections' area. Show priority tags (High, Medium, Low) in a FlexLayout so that they wrap onto the next line when there is no room. In a comment, explain where you used Auto, * (star) and absolute sizes in your row and column definitions and why.


<img src="Screenshots/Assignment1/task5_1.png"
     alt="CollectionView running on Android Emulator"
     width="300" />


---

![Inspector Management App running on Android Emulator](Screenshots/Assignment1/task5_2.png)


## 6. Test the layout in portrait and landscape and on a small and a large emulator. Nothing may be clipped or overlapping. Save before and after screenshots in a /docs folder and note what you had to change.

## Task 6 – Responsive Layout Testing

### Testing Devices

The dashboard was tested on two Android emulator profiles:

- **Small Device:** Pixel 4a
- **Large Device:** Pixel 9

Both devices were tested in portrait and landscape orientations.

### Test Results

| Device | Orientation | Result |
|---|---|---|
| Pixel 4a | Portrait | Passed |
| Pixel 4a | Landscape | Passed |
| Pixel 9 | Portrait | Passed |
| Pixel 9 | Landscape | Passed |

### Observations

- Dashboard content remains readable across different screen sizes.
- Summary cards maintain a two-column layout.
- Inspection details are displayed correctly.
- The `ScrollView` allows users to scroll vertically when content exceeds the available screen height.
- No horizontal clipping or major layout issues were observed.
- The layout works in both portrait and landscape orientations.

### Conclusion

Responsive testing was completed successfully on small and large Android emulator profiles.

<img src="Screenshots/Assignment1/task6_small1.png"
     alt="CollectionView running on Android Emulator"
     width="300" />

<img src="Screenshots/Assignment1/task6_small2.png"
     alt="ListView running on Android Emulator"
     width="300" />

<img src="Screenshots/Assignment1/task6_large1.png"
     alt="CollectionView running on Android Emulator"
     width="300" />

<img src="Screenshots/Assignment1/task6_large2.png"
     alt="ListView running on Android Emulator"
     width="300" />




## 7. Create InspectionListPage using a CollectionView with at least 10 hardcoded inspections (title, site, status, scheduled date) and an ItemTemplate. Highlight the selected item. Then build the same list once using a ListView and write a short comparison: which one would you choose for a list of 1,000 items, and why?

<img src="Screenshots/Assignment1/task7_1.png"
     alt="CollectionView running on Android Emulator"
     width="300" />

<img src="Screenshots/Assignment1/task7_2.png"
     alt="ListView running on Android Emulator"
     width="300" />

### Implementation

Created two inspection list pages using the same `Inspection` model and 10 hardcoded inspection records.

**1. CollectionView**
- Displays inspections using an `ItemTemplate`.
- Supports single-item selection.
- Highlights the selected item using Visual States.
- Provides better performance for larger data collections.

**2. ListView**
- Displays the same 10 inspection records.
- Uses `ViewCell` and an `ItemTemplate`.
- Included for comparison with CollectionView.

### CollectionView vs ListView

| Feature | CollectionView | ListView |
|---|---|---|
| Performance | Better for large lists | Less efficient for large lists |
| Layout | Supports flexible layouts | Primarily list-based |
| Selection | Supports item selection | Supports item selection |
| Status | Recommended for modern MAUI apps | Deprecated |

### Which would I choose for 1,000 items?

I would choose **CollectionView** because it provides better performance, supports flexible layouts, and is the recommended control for displaying collections in modern .NET MAUI applications.

ListView is deprecated, so CollectionView is the better choice for new applications.


## 8. Use at least five different common controls across your pages (for example Label, Button, Entry, Image, Picker, Switch, DatePicker). Include an image and a custom font added through the project's Resources.

Controls:

<img src="Screenshots/Assignment1/task8_1.png"
     alt="CollectionView running on Android Emulator"
     width="300" />

Font:

<img src="Screenshots/Assignment1/task8_2.png"
     alt="ListView running on Android Emulator"
     width="300" />


## 9. Move every colour, font size and spacing value into a ResourceDictionary. No page may contain a hardcoded colour. Use StaticResource and define at least one implicit style and two explicit styles.

Moved commonly used colours, font sizes, spacing, padding, and dimensions into shared ResourceDictionaries (`Colors.xaml` and `Styles.xaml`).

- Used `StaticResource` to apply shared resources across Dashboard, Inspector Profile, and Inspection List pages.
- Created implicit styles for common controls such as Labels, Buttons, and Borders.
- Created explicit styles for page headings, cards, dashboard sections, and inspection list items.
- Removed hardcoded styling values from the updated pages to maintain a consistent UI and simplify future changes.

**Result:** Improved UI consistency, reusability, and maintainability.


## 10. Create a reusable custom control StatusBadge (a ContentView with a bindable Status property) that shows Pending, In Progress or Completed in a different colour. Use it on the list and on the dashboard. Create a ControlTemplate for a card and use it on both the dashboard and the profile page.


<img src="Screenshots/Assignment1/task10_1.png"
     alt="ListView running on Android Emulator"
     width="300" />


## 11. Write REFACTOR.md: list at least 3 places where you removed duplicated XAML or simplified a layout, with a short before and after for each.

`REFACTOR.md`