using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritzAps.Model
{
    public class Product
    {
        //Product klassens felter defineres
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int ProductionTimeInDays { get; set; }
        public int WarehouseId { get; set; }
        public List<Material>? Materials { get; set; } // Den kan være nullable i guess?

        //Konstruktor for Product når objekterne laves ved at loade dem ind fra database
        public Product(int productId, string productName, int productionTimeInDays, int warehouseId)
        {
            ProductId = productId;
            ProductName = productName;
            ProductionTimeInDays = productionTimeInDays;
            WarehouseId = warehouseId;
            Materials = [];
        }

        //Konstruktor for product når objekter laves i programmet og så gemmes i database
        public Product(string productName, int productionTimeInDays, int warehouseId)
        {
            ProductId++; //+1 for hvert tilføjet objekt
            ProductName = productName;
            ProductionTimeInDays= productionTimeInDays;
            WarehouseId = warehouseId;
            Materials = [];
        }
    }
}
