namespace BritzAps.Model
{
    public class Employee
    {
        //Attributterne / fields sættes for klassen Employee
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int PhoneNumber { get; set; }
        public int RelativePhone { get; set; }
        public string RelativeName { get; set; }
        public int WarehouseId { get; set; }


        // Første konstruktor for Employee. Bruges hvis alle oplysninger på Employee er kendt. Bruges altså når employees loades ind fra en database hvor employeeId er kendt.
        public Employee(int id, string firstName, string lastName, int phoneNumber, int relativePhone, string relativeName, int warehouseId)
        {
            EmployeeId = id;
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            RelativePhone = relativePhone;
            RelativeName = relativeName;
            WarehouseId = warehouseId;
        }

        // Anden konstruktor for Employee. Bruges til at oprette employees, når der er loaded employees fra databasen.
        public Employee(string firstName, string lastName, int phoneNumber, int relativePhone, string relativeName, string warehouseAddress)
        {
            EmployeeId++; //Tilføjer +1 til employeeId pr. employee oprettet. Hvis der loades 25 employees ind fra databasen, så bliver den næste employee Id altsp 26.
            FirstName = firstName;
            LastName = lastName;
            PhoneNumber = phoneNumber;
            RelativePhone = relativePhone;
            RelativeName = relativeName;
            WarehouseId = WarehouseRepository.GetWarehouse(warehouseAddress); //.GetWarehouse(string) metode bruges til at finde ID'et på warehouse
        }

        //Når der bruges employee-objekt.ToString(); bliver dette vist:
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}";
        }
    }
}
