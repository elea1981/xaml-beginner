using System.ComponentModel;
using System.Runtime.CompilerServices;
using RestaurantManager.Models.Annotations;

namespace RestaurantManager.Models
{
    public class OrderItem : INotifyPropertyChanged
    {
        public string Name { get; set; }
        private int number;
        public int Number
        {
            get { return this.number; }
            set
            {
                if (this.number != value)
                {
                    this.number = value;
                    this.OnPropertyChanged(nameof(this.Number));
                }

            }
        }

        public OrderItem()
        {
            this.Number = 1;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            //if (this.PropertyChanged != null)
            //    this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));

        }
    }
}