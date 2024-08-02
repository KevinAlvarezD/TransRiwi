using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Driver : User
{
    public string LicenseNumber { get; set; }
    public string LicenseCategory { get; set; }
    public int DrivingExperience { get; set; }
    //constructor
    public Driver(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adreess, string licenseNumber, string licenseCategory, int drivingExperience) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, adreess)
    {
        LicenseNumber = licenseNumber;
        LicenseCategory = licenseCategory;
        DrivingExperience = drivingExperience;
    }

    public static List<Driver> drivers = new List<Driver>{
         new Driver("Juan", "Perez", "CC", "1234567890", new DateOnly(1990, 1, 1), "juan@example.com", "1234567890", "Calle 123 #456, Colonia San Francisco","1234567890","B2", 4),
         new Driver("Ana", "Garcia", "CC", "9876543210", new DateOnly(1991, 3, 5), "garcia@example.com", ",9876543210", "Calle 478 #128, Manrique","9876543210","A2",4),
         new Driver("Pedro", "Lopez", "CC", "0123456789", new DateOnly(1992, 7, 15), "lopez@example.com", "0123456789", "Calle 345 #6, Robledo","0123456789", "B2", 6 ),
         new Driver("Maria", "Martinez", "CC", "9012345678", new DateOnly(1993, 11, 20), "martinez@example.com", "9012345678", "Calle 879 #548, Esmeraldas", "31548476154", "B2", 5),
         new Driver("Jose", "Ruiz", "CC", "1234567890", new DateOnly(1994, 5, 1), "ruiz@example.com", "1234567890", "Calle 654 #321, San Antonio","1234567890", "A2", 3),
         new Driver("Angel", "Gomez", "CC", "2345678901", new DateOnly(1995, 9, 17), "gomez@example.com", "2345678901", "Calle 789 #9, Guadalajara","2345678901", "B2", 7),
         new Driver("Luis", "Perez", "CC", "3456789012", new DateOnly(1996, 3, 25), "perez@example.com", "3456789012", "Calle 567 #13, Toluca","3456789012", "B2", 6),
         new Driver("Maria", "Sanchez", "CC", "4567890123", new DateOnly(1997, 7, 10), "sanchez@example.com", "4567890123", "Calle 456 #21, Mexico City","4567890123", "A2", 4),
         new Driver("Juan", "Escobar", "CC", "5678901234", new DateOnly(1998, 11, 18), "escobar@example.com", "5678901234", "Calle 321 #654, Cancun","5678901234", "B2", 5),
         new Driver("Pedro", "Sandoval", "CC", "6789012345", new DateOnly(1999, 5, 7), "sandoval@example.com", "6789012345", "Calle 987 #543, Guadalajara","6789012345", "B2", 3)
    };
    
    //metodos
    public static void UpdateLicenseCategory(){
        //Pedir al usuario el nombre del driver para cambiar su categoría de licencia
        //especificar la nueva categoría

        Console.WriteLine("Ingrese el nombre del conductor para cambiar su categoría de licencia: ");
        string driverName = Console.ReadLine();
        var driver = drivers.FirstOrDefault(d => d.Name.ToLower() == driverName.ToLower());
        if (driver!= null)
        {
            Console.WriteLine("Ingrese la nueva categoría de licencia: ");
            string newCategory = Console.ReadLine();
            driver.LicenseCategory = newCategory;
            Console.WriteLine($"La categoría de licencia del conductor {driver.Name} ha sido cambiada a {driver.LicenseCategory}.");
        }
        else
        {
            Console.WriteLine("No se encontro al conductor.");
        }
        Thread.Sleep(4000);
    }
   
    public static void AddDrivingExperience(){
        //Pedir al usuario el nombre del driver para aumentar sus años de experiencia
        //especificar la cantidad de años que desea incrementar

        Console.WriteLine("Ingrese el nombre del conductor para aumentar sus años de experiencia: ");
        string driverName = Console.ReadLine();
        var driver = drivers.FirstOrDefault(d => d.Name.ToLower() == driverName.ToLower());
        if (driver!= null)
        {
            Console.WriteLine("Ingrese la cantidad de años que desea incrementar: ");
            int years = Convert.ToInt32(Console.ReadLine());
            driver.DrivingExperience += years;
            Console.WriteLine($"El conductor {driver.Name} tiene {driver.DrivingExperience} años de experiencia.");
        }
        else
        {
            Console.WriteLine("No se encontro al conductor.");
        }
        Thread.Sleep(4000);
    }
   

     public static void ShowDetails()
    {

          Console.WriteLine("===========================================================================");
          Console.WriteLine("                          INFORMACION PERSONAL                             ");
          Console.WriteLine("===========================================================================");
      foreach (var driver in drivers )
      {
          Console.WriteLine("| {0,-1} | {1,-43} |", "ID                   |", $"{driver.Id}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Nombre               |", $"{driver.Name}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Apellido             |", $"{driver.LastName}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Tipo De Documento    |", $"{driver.TypeDocument}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Numero de Documento  |", $"{driver.IdentificationNumber}");   
          Console.WriteLine("| {0,-1} | {1,-43} |", "Cumpleaños           |", $"{driver.BirthDate.ToString("dd/MM/yyyy")}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Email                |", $"{driver.Email}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Telefono             |", $"{driver.PhoneNumber}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Direccion            |", $"{driver.Adreess}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Nº Licensia          |", $"{driver.LicenseNumber}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Categoría de Licencia |", $"{driver.LicenseCategory}");
          Console.WriteLine("| {0,-1} | {1,-43} |", "Experiencia en Conducir |", $"{driver.DrivingExperience} años");
          driver.ShowAge();
          Console.WriteLine("============================================================================");
          Thread.Sleep(3000);
      }
    }

}
