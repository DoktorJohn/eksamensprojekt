using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BritzAps.Model
{
    public class StorageSpaceRepository
    {
        // "Singleton" pattern fra Csharpindepth.com. Sikrer at der kun oprettes maximalt 1 instans af repositoriet.
        private static StorageSpaceRepository? instance = null;
        private static readonly object locker = new();
        StorageSpaceRepository() { }
        public static StorageSpaceRepository Instance
        {
            get
            {
                lock (locker)
                {
                    // Tjekker om der er lavet en instans af repositoriet. Hvis der ikke er, så kan der laves et.
                    if (instance == null)
                    {
                        instance = new StorageSpaceRepository();
                    }

                    return instance;
                }
            }
        }

        public static List<StorageSpace> StorageSpaces { get; set; } = [];

        public static int GetStorageSpaceId(string code)
        {
            foreach (var storageSpace in StorageSpaces)
            {
                if (code == storageSpace.StorageSpaceCode)
                {
                    return storageSpace.StorageSpaceId;
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
