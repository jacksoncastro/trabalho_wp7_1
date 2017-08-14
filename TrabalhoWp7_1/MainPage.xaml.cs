using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

// O modelo de item de Página em Branco está documentado em https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x416

namespace TrabalhoWp7_1
{
    /// <summary>
    /// Uma página vazia que pode ser usada isoladamente ou navegada dentro de um Quadro.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {

            this.InitializeComponent();

            this.DataContext = ItemsManager.Items;
        }


        private void GoToItem(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            var hyperlinkButton = sender as HyperlinkButton;
            var itemId = hyperlinkButton.CommandParameter;

            this.Frame.Navigate(typeof(Detail), itemId);
        }
    }
}
