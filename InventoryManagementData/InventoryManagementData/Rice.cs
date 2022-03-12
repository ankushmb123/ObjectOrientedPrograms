using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementData
{
    internal class InventoryFactory
    {
        public List<InventoryModel> Rice { get; set; }
        public List<InventoryModel> Wheat { get; set; }
        public List<InventoryModel> Pulses { get; set; }
    }
    class InventoryModel
    {

        public string Name { get; set; }
        public int Weight { get; set; }
        public int Price { get; set; }
    }
     class InventorystockMain
    { 
        public string Stockname { get; set; }
    public int Numberofshare { get; set; }
    public int Shareprice { get; set; }

        internal void DisplayData(string v)
        {
            throw new NotImplementedException();
        }
    }
}