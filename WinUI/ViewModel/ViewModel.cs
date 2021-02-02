using Microsoft.UI.Xaml.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinUIDemoApp.Model;

namespace WinUIDemoApp
{
    public class ViewModel
    {
        ObservableCollection<OrderInfo> orders;
        public ObservableCollection<OrderInfo> Orders
        {
            get { return orders; }
            set { orders = value; }
        }

        public ViewModel()
        {
            orders = new ObservableCollection<OrderInfo>();
            Orders = GenerateOrders();
        }

        public ObservableCollection<OrderInfo> GenerateOrders()
        {
            orders.Add(new OrderInfo(1, "Maria Anders", "Germany", "ALFKI", "Berlin", getorder(1001)));
            orders.Add(new OrderInfo(2, "Ana Trujilo", "Mexico", "ANATR", "México D.F.", getorder(1002)));
            orders.Add(new OrderInfo(3, "Antonio Moreno", "Mexico", "ANTON", "México D.F.", getorder(1003)));
            orders.Add(new OrderInfo(4, "Thomas Hardy", "UK", "AROUT", "London", getorder(1004)));
            orders.Add(new OrderInfo(5, "Christina Berglund", "Sweden", "BERGS", "Luleå", getorder(1005)));
            orders.Add(new OrderInfo(6, "Hanna Moos", "Germany", "BLAUS", "Mannheim", getorder(1006)));
            orders.Add(new OrderInfo(7, "Frédérique Citeaux", "France", "BLONP", "Strasbourg", getorder(1007)));

            orders.Add(new OrderInfo(8, "Martin Sommer", "Spain", "BOLID", "Madrid", getorder(1008)));
            orders.Add(new OrderInfo(9, "Laurence Lebihan", "France", "BONAP", "Marseille", getorder(1009)));
            orders.Add(new OrderInfo(10, "Elizabeth Lincoln", "Canada", "BOTTM", "Tsawassen", getorder(1010)));

            orders.Add(new OrderInfo(11, "Antonio Moreno", "Mexico", "ANTON", "México D.F.", getorder(1011)));
            orders.Add(new OrderInfo(12, "Thomas Hardy", "UK", "AROUT", "London", getorder(1012)));
            orders.Add(new OrderInfo(13, "Christina Berglund", "Sweden", "BERGS", "Luleå", getorder(1013)));
            orders.Add(new OrderInfo(14, "Hanna Moos", "Germany", "BLAUS", "Mannheim", getorder(1014)));
            orders.Add(new OrderInfo(15, "Frédérique Citeaux", "France", "BLONP", "Strasbourg", getorder(1015)));

            return orders;
        }

        List<ProductInfo> products = new List<ProductInfo>();

        public List<ProductInfo> getorder(int i)
        {
            List<ProductInfo> product = new List<ProductInfo>();
            foreach (var or in products)
                if (or.OrderID == i)
                    product.Add(or);
            return product;
        }
    }
}
