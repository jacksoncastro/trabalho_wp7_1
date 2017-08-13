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

        public Item(int Id, String ImageUrl, String Name, Double Value, String Description)
        {
            this.Id = Id;
            this.ImageUrl = ImageUrl;
            this.Name = Name;
            this.Value = Value;
            this.Description = Description;
        }

        public int Id {get; set;}

        public String ImageUrl { get; set; }

        public String Name { get; set; }

        public Double Value { get; set; }

        public String Description { get; set; }
    }
}