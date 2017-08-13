using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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


            var Items = new ObservableCollection<Item>() {
                new Item(1, "Flower", "flower.jpg"),
                new Item(2, "Snake", "snake.jpg"),
                new Item(3, "Sunset", "sunset.jpg")
            };

            this.DataContext = Items;
        }


        private void GoToItem(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
        }
    }
}
