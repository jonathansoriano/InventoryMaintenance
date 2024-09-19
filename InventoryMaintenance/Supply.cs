using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryMaintenance
{
    public class Supply : InvItem
    {
        public Supply() { }
        public Supply(int intemNo, string description, decimal price, string manufacturer):
            base(intemNo, description, price)
        { 
            this.Manufacturer = manufacturer;
        }

        public string Manufacturer {  get; set; }

        public override string GetDisplayText()
        {
            return $"{ItemNo} {Manufacturer} {Description} ({Price:c})";
        }


        // Setter and Getter Property:

        /*
         * In C#, properties are not exactly methods, but give the power of methods. 
         * Properties try to give the appearance of fields/attributes, but can do more than just a plain field.
         * Getter in C#: "string name = person.Name;" or Console.WriteLine(person.Name)
           Setter in C#: "person.Name = "John";" since we are trying to change the value of Name.
         */

        // "$" sign in C#. (Interpolation)
        /*
         * If you want to do interpolation (equivalent to concat (+) in java) you have to start out the string with
         * "$" sign. If you want to include a field in the string you have to use {} brackets around the field name.
         * No need to use (+) to include spaces. You just just use a space in the string and it spaces the strings.
         */


    }
}
