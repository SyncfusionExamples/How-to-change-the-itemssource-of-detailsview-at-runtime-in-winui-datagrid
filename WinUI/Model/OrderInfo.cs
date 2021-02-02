using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDemoApp.Model
{
    public class OrderInfo : INotifyPropertyChanged
    {
        int orderID;
        string customerId;
        string country;
        string customerName;
        string shippingCity;
        List<ProductInfo> productDetails;

        public int OrderID
        {
            get { return orderID; }
            set
            {
                orderID = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string CustomerID
        {
            get { return customerId; }
            set
            {
                customerId = value;
                OnPropertyChanged("CustomerID");
            }
        }

        public string CustomerName
        {
            get { return customerName; }
            set
            {
                customerName = value;
                OnPropertyChanged("CustomerName");
            }
        }

        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                OnPropertyChanged("Country");
            }
        }

        public string ShipCity
        {
            get { return shippingCity; }
            set
            {
                shippingCity = value;
                OnPropertyChanged("ShipCity");
            }
        }

        public List<ProductInfo> ProductDetails
        {
            get { return productDetails; }
            set
            {
                productDetails = value;
                OnPropertyChanged("ProductDetails");
            }
        }

        public OrderInfo()
        {

        }
        public OrderInfo(int orderId, string customerName, string country, string customerId, string shipCity, List<ProductInfo> productdetails)
        {
            this.OrderID = orderId;
            this.CustomerName = customerName;
            this.Country = country;
            this.CustomerID = customerId;
            this.ShipCity = shipCity;
            this.ProductDetails = productdetails;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(String name)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(name));
            }
        }
    }
}
