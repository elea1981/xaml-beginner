using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Notifications;
using Windows.UI.Xaml.Media;

namespace RestaurantManager.Models
{
    public class DataManager
    {
        #region Propiedades

        //public ObservableCollection<string> SelectedMenuItems { get; set; }
        public ObservableCollection<Order> Orders { get; set; }
        public List<string> MenuItems { get; set; }
        public ObservableCollection<string> CurrentlySelectedMenuItems { get; set; }

        #endregion

        #region Constructores

        public DataManager()
        {
            //this.SelectedMenuItems = new ObservableCollection<string>(
            //    new List<string>
            //    {
            //       "Steak, Chicken, Peas",
            //       "Rice, Chicken",
            //       "Hummus, Pita"
            //    }
            //    );

            this.Orders = new ObservableCollection<Order>
            {
                   new Order {SelectedMenuItems =new List<string> { "Steak", "Chicken","Peas"}, Requests = "req"},
                   new Order {SelectedMenuItems = new List<string>{ "Rice", "Chicken"}, Requests =""},
                   new Order {SelectedMenuItems = new List<string>{ "Hummus", "Pita"}, Requests = ""}
                };

            this.MenuItems = new List<string>
           {
               "Steak",
               "Chicken",
               "Peas",
               "Rice",
               "Hummus",
               "Pita"
           };

            this.CurrentlySelectedMenuItems = new ObservableCollection<string>
           {
               "Rice",
               "Pita"
           };

        }

        #endregion
    }

    public class Order
    {
        public List<string> SelectedMenuItems { get; set; }
        public string Requests { get; set; }
    }


    public class DataViewModel
    {
        public DataManager Data { get; set; }

        public DataViewModel()
        {
            this.Data = new DataManager();

        }
    }
}
