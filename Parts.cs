using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Task
{
    internal abstract class Parts
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int PartInventory { get; set; }
        public decimal PartPrice { get; set; }
        public int PartMin { get; set; }
        public int PartMax { get; set; }

    }
}
