using C__Task;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace C__Task
{
    internal class InHouse : Parts
    {

        // Declare MachineId attribute
        public int MachineId { get; set; }

        // Create Inhouse Constructor
        public InHouse(int partId, string partName, int partInventory, decimal partPrice, int partMin, int partMax, int machineId)
        {
            this.PartId = partId;
            this.PartName = partName;
            this.PartInventory = partInventory;
            this.PartPrice = partPrice;
            this.PartMin = partMin;
            this.PartMax = partMax;
            this.MachineId = machineId;
        }

        // Create another constructor without the machineId argument
        /*
        public InHouse(int partId, string partName, int partInventory, decimal partPrice, int partMin, int partMax)
        {
            this.PartId = partId;
            this.PartName = partName;
            this.PartInventory = partInventory;
            this.PartPrice = partPrice;
            this.PartMin = partMin;
            this.PartMax = partMax;
        }
        */
    }
}
