using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading;
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
using RestaurantManager.Models;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        private DataViewModel dataModel = (DataViewModel)Application.Current.Resources["DataViewModel"];

        public OrderPage()
        {
            this.InitializeComponent();
        }

        private void btnSubmit_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.lvSelected.Items.Any())
            {
                if (Utilities.FindVisualChildren<ToggleButton>(this).Any(t => t.IsChecked.HasValue && t.IsChecked.Value))
                {
                    ToggleButton btnSelected =
                        Utilities.FindVisualChildren<ToggleButton>(this)
                            .First(t => t.IsChecked.HasValue && t.IsChecked.Value);
                    this.dataModel.Data.Orders.Add(
                        new Order
                        {
                            SelectedMenuItems = this.lvSelected.Items.Cast<OrderItem>().ToList(),
                            Requests = this.txtRequests.Text,
                            Table = btnSelected.Content?.ToString()
                        });
                    this.dataModel.Data.CurrentlySelectedMenuItems.Clear();
                    btnSelected.IsChecked = false;
                    this.txtRequests.Text = string.Empty;
                }
                else
                {
                    Utilities.ShowMessage(Application.Current.Resources["SelTable"].ToString());
                }
            }
            else
            {
                Utilities.ShowMessage(Application.Current.Resources["SelItem"].ToString());
            }
        }

        private void btnAdd_OnClick(object sender, RoutedEventArgs e)
        {

            this.lvAvailable.SelectedItems.Cast<string>().ToList().ForEach(i =>
            {
                if (this.dataModel.Data.CurrentlySelectedMenuItems.Select(s => s.Name).Contains(i.ToString()))
                {
                    this.dataModel.Data.CurrentlySelectedMenuItems.First(s => s.Name == i).Number++;
                }
                else
                {
                    this.dataModel.Data.CurrentlySelectedMenuItems.Add(new OrderItem { Name = i });
                }
            });

            this.lvAvailable.SelectedItems.Clear();
        }


        private void ToggleButton_OnChecked(object sender, RoutedEventArgs e)
        {
            Utilities.FindVisualChildren<ToggleButton>(this).Where(t => t != sender).ToList().ForEach(t =>
                {
                    t.IsChecked = false;
                });
        }
    }
}
