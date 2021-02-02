using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUIDemoApp.Model
{
    public class ProductInfo : INotifyPropertyChanged
    {
        int orderId;
        string productName;

        public int OrderID
        {
            get { return orderId; }
            set
            {
                orderId = value;
                OnPropertyChanged("OrderID");
            }
        }

        public string ProductName
        {
            get { return productName; }
            set
            {
                productName = value;
                OnPropertyChanged("ProductName");
            }
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
