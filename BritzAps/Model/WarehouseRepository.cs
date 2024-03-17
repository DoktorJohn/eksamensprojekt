using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritzAps.Model
{
    public class WarehouseRepository
    {
        // "Singleton" pattern fra Csharpindepth.com. Sikrer at der kun oprettes maximalt 1 instans af repositoriet.
        private static WarehouseRepository? instance = null;
        private static readonly object locker = new();
        WarehouseRepository() { }
        public static WarehouseRepository Instance
        {
            get
            {
                lock (locker)
                {
                    // Tjekker om der er lavet en instans af repositoriet. Hvis der ikke er, så kan der laves et.
                    if (instance == null)
                    {
                        instance = new WarehouseRepository();
                    }

                    return instance;
                }
            }
        }

        public static List<Warehouse> Warehouses { get; set; } = new List<Warehouse>();


        //Metode til at returnere et warehouse's ID ud fra den indtastede addresse.
        public static int GetWarehouse(string address) //Statisk returnerer en integer, benytter sig af address paramter
        {
            //Går listen af warehouses igennem
            foreach (var warehouse in Warehouses)
            {
                //Hvis det indtastede addresse parameter stemmer overens med en af warehouse i listen's address, så returneres warehouses ID.
                if (warehouse.Address.Equals(address))
                {
                    return warehouse.WarehouseId;
                }

                else
                {
                    return 0;
                }
            }

            return 0;
        }
    }
}
