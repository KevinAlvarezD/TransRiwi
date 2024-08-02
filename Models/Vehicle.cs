using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Vehicle
{
    public int Id { get; set; }
    public string Placa { get; set; }
    public string Tipo { get; set; }
    public string EngineNumber { get; set; }
    public string SerialNumber { get; set; }
    public byte PeopleCapacity { get; set; }
    public Driver Owner { get; set; }
    //crea lista de vehiculos con 10 vehiculos ya quemados
    public static List<Vehicle> Vehicles = new List<Vehicle> 
    { new Vehicle(1, 
    "ABC123", 
    "Automovil", 
    "1234567890", 
    "ABCDEFGHIJ",
     5, 
      new Driver("Juan", "Perez", "CC", "1234567890", new DateOnly(1990, 1, 1), "juan@example.com", "1234567890", "Calle 123 #456, Colonia San Francisco","1234567890","B2", 4))
    , new Vehicle(2,
     "DEF456", 
     "Motocicleta",
      "9876543210", 
      "KLMNOPQRST",
       2, 
      new Driver("Ana", "Garcia", "CC", "9876543210", new DateOnly(1991, 3, 5), "garcia@example.com", ",9876543210", "Calle 478 #128, Manrique","9876543210","A2",4)),
      new Vehicle(3,
     "GHI789",
     "Camioneta", 
      "0123456789", 
      "UVWXYZABCDEF",
       6, 
      new Driver("Pedro", "Lopez", "CC", "0123456789", new DateOnly(1992, 7, 15), "lopez@example.com", "0123456789", "Calle 345 #6, Robledo","0123456789", "B2", 6 )),
      new Vehicle(4,
      "JKL901",
      "Micro Bus", 
      "9012345678", 
      "GHIJKLMNOPQ",
       3, 
      new Driver("Maria", "Martinez", "CC", "9012345678", new DateOnly(1993, 11, 20), "martinez@example.com", "9012345678", "Calle 879 #548, Esmeraldas", "31548476154", "B2", 5)),
      new Vehicle(5,
      "MNO012",
      "Motocicleta", 
      "1234567890", 
      "QRSTUVWXYZ",
      5, 
      new Driver("Jose", "Ruiz", "CC", "1234567890", new DateOnly(1994, 5, 1), "ruiz@example.com", "1234567890", "Calle 654 #321, San Antonio","1234567890", "A2", 3)),
      new Vehicle(6,
      "PQR345",
      "Camioneta", 
      "2345678901", 
      "QWERTYUIOP",
       6,
       new Driver("Angel", "Gomez", "CC", "2345678901", new DateOnly(1995, 9, 17), "gomez@example.com", "2345678901", "Calle 789 #9, Guadalajara","2345678901", "B2", 7)),

      new Vehicle(7,
      "STU456",
      "Micro Bus", 
      "3456789012", 
      "ASDFGHJKL",
      3, 
      new Driver("Luis", "Perez", "CC", "3456789012", new DateOnly(1996, 3, 25), "perez@example.com", "3456789012", "Calle 567 #13, Toluca","3456789012", "B2", 6)),
      new Vehicle(8,
      "VWX567",
      "Motocicleta", 
      "4567890123", 
      "ZXCVBNML",
      5, 
      new Driver("Maria", "Sanchez", "CC", "4567890123", new DateOnly(1997, 7, 10), "sanchez@example.com", "4567890123", "Calle 456 #21, Mexico City","4567890123", "A2", 4)),
      new Vehicle(9,
      "YZA678",
      "Camioneta", 
      "5678901234", 
      "QWERTYUIOP",
      6,
      new Driver("Juan", "Escobar", "CC", "5678901234", new DateOnly(1998, 11, 18), "escobar@example.com", "5678901234", "Calle 321 #654, Cancun","5678901234", "B2", 5)),
      new Vehicle(10,
      "BCD789",
      "Automovil", 
      "6789012345", 
      "ASDFGHJKL",
      5,
      new Driver("Pedro", "Sandoval", "CC", "6789012345", new DateOnly(1999, 5, 7), "sandoval@example.com", "6789012345", "Calle 987 #543, Guadalajara","6789012345", "B2", 3))  
      };
    //constructor
    public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
    {
        Id = id;
        Placa = placa;
        Tipo = tipo;
        EngineNumber = engineNumber;
        SerialNumber = serialNumber;
        PeopleCapacity = peopleCapacity;
        Owner = owner;
    }

    //metodos
    public static void DeleteVehicle(){
        //pedir al usuario el vehiculo que quiere eliminar
        Console.WriteLine("Ingrese la placa del vehículo que desea eliminar:");
        var placaToDelete = Console.ReadLine();
        //busca el vehiculo en la lista y lo elimina
        var vehicleToDelete = Vehicles.FirstOrDefault(v => v.Placa == placaToDelete);
        if (vehicleToDelete!= null)
        {
            Vehicles.Remove(vehicleToDelete);
            Console.WriteLine($"El vehículo con placa {vehicleToDelete.Placa} ha sido eliminado correctamente.");
        }
        else
        {
            Console.WriteLine("No se encontró el vehículo con la placa ingresada.");
        }
     }
      
}
