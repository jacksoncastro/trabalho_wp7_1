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
                new Item(1, "http://img0.icarros.com/dbimg/imgmodelo/2/231_18", "Honda Civic 2017", 87.900, "Nota 9.1"),
                new Item(2, "http://img2.icarros.com/dbimg/imgmodelo/2/233_8", "Honda Fit", 57.700, "Nota 8,3"),
                new Item(3, "http://img1.icarros.com/dbimg/imgmodelo/2/1036_8", "Honda City", 60.900, "Nota 8,4"),
                new Item(4, "http://img2.icarros.com/dbimg/imgmodelo/2/2627_1", "Honda HR-V", 79.900, "Nota 8,5"),
                new Item(5, "http://img2.icarros.com/dbimg/imgmodelo/2/647_7", "Honda CR-V", 148.000, "Nota 9,1"),
                new Item(6, "http://img2.icarros.com/dbimg/imgmodelo/2/2720_3", "Honda WR-V", 79.400, "Nota 9,5")
            };

            this.DataContext = Items;
        }


        private void GoToItem(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
        }
    }
}
