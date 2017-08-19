using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text.RegularExpressions;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=234238

namespace TrabalhoWp7_1
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class EditProduct : Page
    {
        private int itemId;
        private Item currentItem;

        public EditProduct()
        {
            this.InitializeComponent();
        }


        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            this.itemId = Convert.ToInt32(e.Parameter);
            var item = ItemsManager.Items.First(itemSearch => itemSearch.Id == this.itemId);

            this.currentItem = item.DeepCopy();

            this.DataContext = item;
        }




        private void Cancel(object sender, RoutedEventArgs e)
        {
            Item item = ItemsManager.Items.First(itemSearch => itemSearch.Id == this.currentItem.Id);

            item.ImageUrl = this.currentItem.ImageUrl;
            item.Name = this.currentItem.Name;
            item.Value = this.currentItem.Value;
            item.Description = this.currentItem.Description;

            this.Frame.Navigate(typeof(MainPage));
        }


        private void Edit(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void OnKeyUpValue(Object sender, KeyRoutedEventArgs e)
        {
            var textBox = sender as TextBox;
        }


        private void OnKeyDownValue(Object sender, KeyRoutedEventArgs e)
        {
            if (!IsDigitKey(e.Key))
            {
                e.Handled = true;
            }
        }


        private bool IsDigitKey(VirtualKey keyValue)
        {
            return ((keyValue >= VirtualKey.Number0 && keyValue <= VirtualKey.Number9) ||
                (keyValue >= VirtualKey.NumberPad0 && keyValue <= VirtualKey.NumberPad9));
        }
    }
}
