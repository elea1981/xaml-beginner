using System.Collections.Generic;

namespace RestaurantManager.Models
{
    public class Order
    {
        // public List<string> SelectedMenuItems { get; set; }
        public List<OrderItem> SelectedMenuItems { get; set; }
        public string Requests { get; set; }
        public string Table { get; set; }
    }

}