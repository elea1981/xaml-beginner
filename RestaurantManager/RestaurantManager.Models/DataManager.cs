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
        //public ObservableCollection<string> CurrentlySelectedMenuItems { get; set; }
        public ObservableCollection<OrderItem> CurrentlySelectedMenuItems { get; set; }

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
                //new Order {SelectedMenuItems =new List<string> { "Steak", "Chicken","Peas"}, Requests = "steak well done, crusty chicken fresh wine"},
                //new Order {SelectedMenuItems = new List<string>{ "Rice", "Chicken"}, Requests ="nothing special"},
                //new Order {SelectedMenuItems = new List<string>{ "Hummus", "Pita"}, Requests = "champagne"}
                new Order {
                        SelectedMenuItems = new List<OrderItem>
                        {
                            new OrderItem { Name = "Steak"},
                            new OrderItem { Name = "Chicken"},
                            new OrderItem { Name ="Peas"}
                        },
                    Requests = "steak well done, crusty chicken fresh wine",
                    Table = "9"},
                new Order {
                    SelectedMenuItems = new List<OrderItem>
                        {
                            new OrderItem {Name="Rice"},
                            new OrderItem { Name = "Chicken"}
                        },
                    Requests ="nothing special",
                    Table="1"},
                new Order {
                    SelectedMenuItems = new List<OrderItem>
                        {
                            new OrderItem { Name = "Hummus"},
                            new OrderItem { Name = "Pita"}

                        },
                    Requests = "champagne",
                    Table="4"}
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

            // this.CurrentlySelectedMenuItems = new ObservableCollection<string>
            //{
            //    "Rice",
            //    "Pita"
            //};
            this.CurrentlySelectedMenuItems = new ObservableCollection<OrderItem>
           {
               new OrderItem { Name="Rice"},
               new OrderItem { Name="Pita"}
           };

        }

        #endregion
    }
}
