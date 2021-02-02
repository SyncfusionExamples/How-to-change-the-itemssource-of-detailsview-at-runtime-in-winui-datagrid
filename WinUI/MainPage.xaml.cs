using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using Syncfusion.UI.Xaml.Data;
using Syncfusion.UI.Xaml.DataGrid;
using System.Reflection;
using System.Globalization;
using Windows.Storage;
using System.Collections.ObjectModel;
using Microsoft.UI;
using WinUIDemoApp.Model;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace WinUIDemoApp
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {

        public MainPage()
        {
            this.InitializeComponent();
            this.dataGrid.Loaded += DataGrid_Loaded;
        }

        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            this.dataGrid.ExpandAllDetailsView();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var viewModel = this.dataGrid.DataContext as ViewModel;
            for (int i = 1; i <= 15; i++)
            {
                var data = viewModel.Orders.FirstOrDefault(item => item.OrderID == i);
                var newItem = new List<ProductInfo>();
                newItem.Add(new ProductInfo() { OrderID = 1000 + i, ProductName = "Bike" });
                data.ProductDetails = newItem;
            }
        }
    }
}
