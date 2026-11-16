
# Refactoring Documentation

This document describes the changes made to reduce duplicated XAML, improve reusability, and simplify layouts in the Inspector Management App.

## 1. Reusable StatusBadge Control

**Before:**

Each inspection item and dashboard card used separate Label elements to display inspection statuses. The background and text colours had to be defined repeatedly.

**After:**

Created a reusable `StatusBadge` ContentView with a bindable `Status` property. DataTriggers change its colours based on the status.

```xml
<controls:StatusBadge Status="{Binding Status}" />
```

The same control is reused in the Dashboard, CollectionView, and ListView.

## 2. Reusable CardControlTemplate

**Before:**

Dashboard and Inspector Profile pages used separate Border elements with repeated card background, border, padding, and corner-radius settings.

**After:**

Created a shared `CardControlTemplate` in `Styles.xaml`.

```xml
<ContentView
    ControlTemplate="{StaticResource CardControlTemplate}">
    <!-- Card content -->
</ContentView>
```

The template is reused for the Dashboard summary cards and Inspector Profile cards.

## 3. Centralized Styles and Resources

**Before:**

Colours, font sizes, spacing, and other visual values were defined directly in page XAML. Updating the design required changing multiple files.

**After:**

Moved reusable visual values into `Colors.xaml` and `Styles.xaml`. Pages now reference shared resources.

```xml
<Label
    Text="My Profile"
    Style="{StaticResource ProfilePageHeadingStyle}" />
```

This makes the application easier to maintain and keeps its appearance consistent.

## 4. Reusable Inspection Status Display

**Before:**

The CollectionView and ListView inspection templates each displayed status using their own Label markup.

**After:**

Both list implementations now use the same `StatusBadge` control.

```xml
<controls:StatusBadge Status="{Binding Status}" />
```

This removes duplicated status-display markup and ensures consistent styling across both lists.

## Conclusion

These refactoring changes improved code reuse, reduced repeated XAML, and made the application easier to maintain. Shared controls, templates, and resource dictionaries also make future UI changes simpler.
