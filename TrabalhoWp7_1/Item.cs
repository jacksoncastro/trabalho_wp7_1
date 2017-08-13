using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoWp7_1
{
    public class Item
    {
        public Item() {}

        public Item(int Id, String ImageUrl, String Name)
        {
            this.Id = Id;
            this.ImageUrl = ImageUrl;
            this.Name = Name;
        }

        public int Id {get; set;}

        public String ImageUrl { get; set; }

        public String Name { get; set; }
    }
}