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
using RestaurantManager.HelperCode;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace RestaurantManager
{
    public sealed partial class UCtrlNavigation : UserControl
    {
        public UCtrlNavigation()
        {
            this.InitializeComponent();
        }

        private void btnHome_OnClick(object sender, RoutedEventArgs e)
        {
            Utilities.Navigate(typeof(MainPage));
        }
    }
}
