using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using RestaurantManager.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class ExpeditePage : Page
    {
        private DataViewModel dataModel = (DataViewModel)Application.Current.Resources["DataViewModel"];


        public ExpeditePage()
        {
            this.InitializeComponent();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            this.dataModel.Data.Orders.Clear();
        }

        private void buttonBase_OnClick(object sender, RoutedEventArgs e)
        {
            this.dataModel.Data.Orders.Remove((Order) ((Button) sender).Tag);
        }
    }
}
