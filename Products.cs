using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task
{
    internal class Products
    {

        public static BindingList<Parts> associatedParts = new BindingList<Parts>();

        public int ProductId { get; set; }
        public string ProductName {  get; set; }
        public int ProductInventory { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductMin {  get; set; }
        public int ProductMax {  get; set; }


        //addAssociatedPart(Part) void
        //removeAssociatedPart(int) bool
        //lookupAssociatedPart(int) Part
    }

}
