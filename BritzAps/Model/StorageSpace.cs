using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritzAps.Model
{
    public class StorageSpace
    {
        // Fields for StorageSpace klasse defineres
        public int StorageSpaceId { get; set; }
        public string StorageSpaceCode { get; set; }
        public int WarehouseId { get; set; }

        //Konstruktor når StorageSpace objekter skal loades ind fra database
        public StorageSpace(int id, string storageSpaceCode, int warehouseId)
        {
            StorageSpaceId = id;
            StorageSpaceCode = storageSpaceCode;
            WarehouseId = warehouseId;
        }

        //Konstruktor når StorageSpace objekter laves i programmet og tilføjes til en database.
        public StorageSpace(string storageSpaceCode, int warehouseId) 
        {
            StorageSpaceId++; //Adder +1 til StorageSpaceId for hvert oprettet objekt
            StorageSpaceCode = StorageSpaceRepository.GetStorageSpaceId(storageSpaceCode);
            WarehouseId = warehouseId;
        }
    }
}
