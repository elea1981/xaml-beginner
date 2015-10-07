namespace RestaurantManager.Models
{
    public class DataViewModel
    {
        public DataManager Data { get; set; }

        public DataViewModel()
        {
            this.Data = new DataManager();

        }
    }
}