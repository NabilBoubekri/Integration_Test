using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Unitaire_1
{
    public class ToDoList
    {
        public List<Item> Items;

        public bool add(Item item)
        {
            if(Items.Count > 10)
            {    
                return false;
            }
            if (Items.Count > 0)
            {
                if ((item.dateCreation - Items[Items.Count - 1].dateCreation).TotalMinutes < 30)
                {
                    return false;
                }
            }
            Items.Add(item);
            return true;
        }
    }
}
