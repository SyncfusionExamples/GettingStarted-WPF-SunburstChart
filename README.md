# Getting Started with WPF Sunburst Chart (SfSunburstChart)

This sample demonstrates how to create a WPF Sunburst Chart using the Syncfusion `SfSunburstChart` control. Follow the steps below to populate the chart with data, add data labels, legends, and a header.

## Prerequisites

- Visual Studio 2022 or later
- .NET 10.0 or later
- Syncfusion WPF package

## Step 1: Add the Syncfusion WPF Sunburst Chart NuGet Package

Open your `.csproj` file and add the following NuGet package reference:

```xml
<ItemGroup>
    <PackageReference Include="Syncfusion.SfSunburstChart.WPF" Version="*" />
</ItemGroup>
```

Or install it via the NuGet Package Manager console:

```
Install-Package Syncfusion.SfSunburstChart.WPF
```

## Step 2: Initialize the ViewModel

### Create the Model class

Define a data model that represents the chart data. Create a file `ViewModel/Model.cs`:

```csharp
namespace SunburstChartWPF
{
    public class Model
    {
        public string Category { get; set; }
        public string Country { get; set; }
        public string JobDescription { get; set; }
        public string JobGroup { get; set; }
        public string JobRole { get; set; }
        public double EmployeesCount { get; set; }
    }
}
```

### Create the ViewModel class

Create a ViewModel that initializes the data collection. Create a file `ViewModel/ViewModel.cs`:

```csharp
using System.Collections.ObjectModel;

namespace SunburstChartWPF
{
    public class ViewModel
    {
        public ObservableCollection<Model> Data { get; set; }
        public ViewModel()
        {
            Data = new ObservableCollection<Model>
            {
                new Model { Country = "America", JobDescription = "Sales", EmployeesCount = 70 },
                new Model { Country = "America", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 35 },
                new Model { Country = "America", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 105 },
                new Model { Country = "America", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 40 },
                new Model { Country = "America", JobDescription = "Management", EmployeesCount = 40 },
                new Model { Country = "America", JobDescription = "Accounts", EmployeesCount = 60 },
                new Model { Country = "India", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 25 },
                new Model { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 155 },
                new Model { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 60 },
                new Model { Country = "Germany", JobDescription = "Sales", JobGroup = "Executive", EmployeesCount = 30 },
                new Model { Country = "Germany", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 },
                new Model { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 100 },
                new Model { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 30 },
                new Model { Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60 },
                new Model { Country = "UK", JobDescription = "Marketing", EmployeesCount = 40 }
            };
        }
    }
}
```

The data used in this sample represents employee counts by country, job description, job group, and job role:

| Country | Job Description | Job Group | Job Role | Employees Count |
|---------|----------------|-----------|----------|-----------------|
| America | Sales | | | 70 |
| America | Technical | Testers | | 35 |
| America | Technical | Developers | Windows | 105 |
| America | Technical | Developers | Web | 40 |
| America | Management | | | 40 |
| America | Accounts | | | 60 |
| India | Technical | Testers | | 25 |
| India | Technical | Developers | Windows | 155 |
| India | Technical | Developers | Web | 60 |
| Germany | Sales | Executive | | 30 |
| Germany | Sales | Analyst | | 40 |
| UK | Technical | Developers | Windows | 100 |
| UK | Technical | Developers | Web | 30 |
| UK | HR Executives | | | 60 |
| UK | Marketing | | | 40 |

## Step 3: Add the SfSunburstChart Namespace

In `MainWindow.xaml`, add the Syncfusion Sunburst Chart namespace:

```xml
xmlns:sunburst="clr-namespace:Syncfusion.UI.Xaml.SunburstChart;assembly=Syncfusion.SfSunburstChart.WPF"
```

## Step 4: Populate the Sunburst Chart with Data

Bind the `Data` property from the ViewModel to the `ItemsSource` property of `SfSunburstChart`. Add `SunburstHierarchicalLevel` entries to the `Levels` property. Each level is grouped based on the `GroupMemberPath` property, and the arc segment size is calculated using `ValueMemberPath`.

```xml
<sunburst:SfSunburstChart ItemsSource="{Binding Data}" ValueMemberPath="EmployeesCount">
    <sunburst:SfSunburstChart.Levels>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
        <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
    </sunburst:SfSunburstChart.Levels>
</sunburst:SfSunburstChart>
```

## Step 5: Add a Header

Add a title to the chart using the `Header` property:

```xml
<sunburst:SfSunburstChart Header="Employees Count" FontSize="22" />
```

## Step 6: Add a Legend

Enable the legend using the `Legend` property:

```xml
<sunburst:SfSunburstChart.Legend>
    <sunburst:SunburstLegend DockPosition="Left"/>
</sunburst:SfSunburstChart.Legend>
```

## Step 7: Add Data Labels

Add data labels to improve the readability of the chart using the `DataLabelInfo` property:

```xml
<sunburst:SfSunburstChart.DataLabelInfo>
    <sunburst:SunburstDataLabelInfo />
</sunburst:SfSunburstChart.DataLabelInfo>
```

## Complete XAML Code

Here is the complete `MainWindow.xaml` code:

```xml
<Window x:Class="SunburstChartWPF.MainWindow"
        xmlns="http://schemas.microsoft.com/winfx/2006/xaml/presentation"
        xmlns:x="http://schemas.microsoft.com/winfx/2006/xaml"
        xmlns:d="http://schemas.microsoft.com/expression/blend/2008"
        xmlns:mc="http://schemas.openxmlformats.org/markup-compatibility/2006"
        xmlns:local="clr-namespace:SunburstChartWPF"
        mc:Ignorable="d"
        xmlns:sunburst="clr-namespace:Syncfusion.UI.Xaml.SunburstChart;assembly=Syncfusion.SfSunburstChart.WPF"
        Title="MainWindow" Height="450" Width="800">
    <Grid>
        <Grid.DataContext>
            <local:ViewModel/>
        </Grid.DataContext>
        <sunburst:SfSunburstChart ItemsSource="{Binding Data}" ValueMemberPath="EmployeesCount"
                                  Header="Employees Count" FontSize="22">
            <sunburst:SfSunburstChart.Legend>
                <sunburst:SunburstLegend DockPosition="Left"/>
            </sunburst:SfSunburstChart.Legend>
            <sunburst:SfSunburstChart.Levels>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="Country"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobDescription"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobGroup"/>
                <sunburst:SunburstHierarchicalLevel GroupMemberPath="JobRole"/>
            </sunburst:SfSunburstChart.Levels>
            <sunburst:SfSunburstChart.DataLabelInfo>
                <sunburst:SunburstDataLabelInfo />
            </sunburst:SfSunburstChart.DataLabelInfo>
        </sunburst:SfSunburstChart>
    </Grid>
</Window>
```

## Theming

The Syncfusion WPF Sunburst Chart supports various built-in themes. You can apply themes in the following ways:

- [Apply theme using SfSkinManager](https://help.syncfusion.com/wpf/themes/skin-manager)
- [Create a custom theme using ThemeStudio](https://help.syncfusion.com/wpf/themes/theme-studio#creating-custom-theme)

## Reference

- [Syncfusion WPF Sunburst Chart – Getting Started Documentation](https://help.syncfusion.com/wpf/sunburst-chart/getting-started)

<img width="1919" height="1007" alt="Screenshot 2026-03-30 114652" src="https://github.com/user-attachments/assets/06fc8c9b-c729-4fd1-af74-1a96946cd371" />

