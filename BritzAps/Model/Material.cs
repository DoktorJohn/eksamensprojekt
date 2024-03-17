using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Xps.Serialization;

namespace BritzAps.Model
{
    public class Material
    {
        // Fields for Material klassen defineres
        public int MaterialId { get; set; }
        public string MaterialType { get; set; }
        public double Price { get; set; }
        public int StorageSpaceId { get; set; }

        //Material konstruktor når der skal loades material ind fra databasen
        public Material(int id, string materialType, double price, int storageSpaceId)
        {
            MaterialId = id;
            MaterialType = materialType;
            Price = price;
            StorageSpaceId = storageSpaceId;
        }

        //Material konstruktor når der skal laves nye objekter og skrives ind i databasen
        public Material(string materialType, double price, int storageSpaceId)
        {
            MaterialId++; //Material +1 for hvert tilføjet objekt
            MaterialType = materialType;
            Price = price;
            StorageSpaceId = storageSpaceId;
        }

    }
}
