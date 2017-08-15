using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWp7_1
{
    public class ItemsManager
    {
        public static ObservableCollection<Item> Items = new ObservableCollection<Item>() {
            new Item(0, "http://img0.icarros.com/dbimg/imgmodelo/2/231_18", "Honda Civic 2017", 87900.00, "Nota 9.1"),
            new Item(1, "http://img2.icarros.com/dbimg/imgmodelo/2/233_8", "Honda Fit", 57700.00, "Nota 8,3"),
            new Item(2, "http://img1.icarros.com/dbimg/imgmodelo/2/1036_8", "Honda City", 60900.00, "Nota 8,4"),
            new Item(3, "http://img2.icarros.com/dbimg/imgmodelo/2/2627_1", "Honda HR-V", 79900.00, "Nota 8,5"),
            new Item(4, "http://img2.icarros.com/dbimg/imgmodelo/2/647_7", "Honda CR-V", 148000.00, "Nota 9,1"),
            new Item(5, "http://img2.icarros.com/dbimg/imgmodelo/2/2720_3", "Honda WR-V", 79400.00, "Nota 9,5")
        };
    }

}
