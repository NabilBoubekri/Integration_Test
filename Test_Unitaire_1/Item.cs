using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitaire_1
{
    public class Item
    {
        public string name {  get; set; }
        public string content {  get; set; }
        public DateTime dateCreation { get; set; }

        public Item(string name, string content) 
        {
            this.name = name;
            this.content = content;
            this.dateCreation = DateTime.Now;
        }

    }
}
