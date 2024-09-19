using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Plant : InvItem
    {
        //InvItem: int Item num, string description, decimal price 
        public Plant() { }
        public Plant(int itemNo, string description, decimal price, string size) :
            base(itemNo, description, price)
        {
            this.Size = size;
        }

        public string Size { get; set; }

        public override string GetDisplayText()
        {
            return $"{ItemNo} {Size} {Description} ({Price:c})";
        }

    }
}
