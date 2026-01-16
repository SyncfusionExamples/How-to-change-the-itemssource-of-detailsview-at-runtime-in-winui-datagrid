# How to Change the ItemsSource of DetailsView at Runtime in WinUI DataGrid?

This example describes how to change the itemssource of detailsview at runtime in [WinUI DataGrid](https://www.syncfusion.com/winui-controls/datagrid) (SfDataGrid).

`ItemsSource` for `DetailsViewDataGrid` is populated from the DataContext of parent row based on [ViewDefinition.RelationalColumn](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.ViewDefinition.html#Syncfusion_UI_Xaml_DataGrid_ViewDefinition_RelationalColumn). DetailsViewDataGrid doesn’t update its ItemsSource at runtime based on the property change, which is mapped the DetailsViewDataGrid ItemsSource. You can update the ItemsSource on the property change by setting [SfDataGrid.LiveDataUpdateMode](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.DataGrid.SfDataGrid.html#Syncfusion_UI_Xaml_DataGrid_SfDataGrid_LiveDataUpdateMode) as `AllowChildViewUpdate`.

#### XAML

``` xml
<dataGrid:SfDataGrid Name="dataGrid"  
                       AutoGenerateColumns="True"
                       AutoGenerateRelations="True"
                       GridLinesVisibility="Both"
                       ItemsSource="{Binding Source}"                              
                       LiveDataUpdateMode="AllowChildViewUpdate,AllowDataShaping">
```
#### C#

``` csharp
this.dataGrid.LiveDataUpdateMode = LiveDataUpdateMode.AllowChildViewUpdate | LiveDataUpdateMode.AllowDataShaping;
```
