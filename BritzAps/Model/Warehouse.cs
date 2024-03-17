using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritzAps.Model
{
    public class Warehouse
    {
        // Warehouse fields defineres
        public int WarehouseId { get; set; }
		public string Address { get; set; }

        //Konstruktor for Warehouse når warehouse objekter skal loades ind fra database
        public Warehouse(int warehouseId, string address)
        {
            WarehouseId = warehouseId;
            Address = address;
        }

        //Konstruktor for warehouse når warehouse objekter skal oprettes i appen og addresse ikke er kendt
        public Warehouse()
        {
            WarehouseId++;
            Address = "UNDETERMINED";
        }

        //Konstruktor for warehouse når warehouse objekter skal oprettes i appen.
        public Warehouse(string address)
        {
            WarehouseId++;
            Address = address;
        }

        //Når warehouse-objekt.ToString(); benyttes, vises dette:
        public override string ToString()
        {
            return $"Warehouse ID: {WarehouseId}, Address: {Address}";
        }
    }
}
