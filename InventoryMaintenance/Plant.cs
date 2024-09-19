using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{   
    //The Plant class shows inheritance by taking the fields from the parent class "InvItem" into our constructor. We also show 
    // inheritance by overriding the method "GetDisplayText" and using the override keyword. 
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
        //Jonathan Sanjuan
        public override string GetDisplayText()
        {
            return $"{ItemNo} {Size} {Description} ({Price:c})";
        }

    }
}
