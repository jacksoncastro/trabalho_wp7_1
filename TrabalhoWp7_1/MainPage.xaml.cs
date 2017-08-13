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
                new Item(1, "http://www.leitecamponesa.com.br/wp-content/uploads/2015/08/produtos-leite-condensado-350x263.png", "Leite condensado 1"),
                new Item(2, "http://www.leitecamponesa.com.br/wp-content/uploads/2015/08/produtos-leite-condensado-350x263.png", "Leite condensado 2"),
                new Item(3, "http://www.leitecamponesa.com.br/wp-content/uploads/2015/08/produtos-leite-condensado-350x263.png", "Leite condensado 3")
            };

            this.DataContext = Items;
        }


        private void GoToItem(object sender, Windows.UI.Xaml.RoutedEventArgs e)
        {
            
        }
    }
}
