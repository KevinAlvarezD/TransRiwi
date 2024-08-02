using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class User
{
    protected Guid Id { get; set; }
    protected string Name { get; set; }
    protected string LastName { get; set; }
    protected string TypeDocument { get; set; }
    protected string IdentificationNumber { get; set; }
    protected DateOnly BirthDate { get; set; }
    protected string Email { get; set; }
    protected string PhoneNumber { get; set; }
    protected string Adreess { get; set; }

    //constructor
    public User(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adreess)
    {
        Id = Guid.NewGuid();
        Name = name;
        LastName = lastName;
        TypeDocument = typeDocument;
        IdentificationNumber = identificationNumber;
        BirthDate = birthDate;
        Email = email;
        PhoneNumber = phoneNumber;
        Adreess = adreess;
    }
    //metodos
    //showDetails()void
    //hacer metodo static para mostrar informacion personal
    public  void ShowDetails()
    {
         Console.WriteLine("==============================================================================");
            Console.WriteLine("                          INFORMACION PERSONAL                             ");
            Console.WriteLine("===========================================================================");
            Console.WriteLine("| {0,-1} | {1,-43} |", "ID                   |",$"{Id}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Nombre               |",$"{Name}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Apellido             |",$"{LastName}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Tipo De Documento    |",$"{TypeDocument}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Numero de Documento  |",$"{IdentificationNumber}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Cumpleaños           |",$"{BirthDate}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Email                |",$"{Email}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Telefono             |",$"{PhoneNumber}");
            Console.WriteLine("| {0,-1} | {1,-43} |", "Direccion            |",$"{Adreess}");
            Console.WriteLine("============================================================================");
    }

    //ShowAge()void
    //volver el metodo showAge() publico para poderlo usar en otros archivos

   int age = 0;
    protected int CalculateAge(int age)
    {
        age = DateTime.Today.Year - BirthDate.Year;
        int monthDiff = DateTime.Today.Month - BirthDate.Month;
        if (monthDiff < 0 || (monthDiff == 0 && DateTime.Today.Day < BirthDate.Day))
        {
            age--;
        }
        return age;
    }
    protected void ShowAge()
    {
        Console.WriteLine($"Edad: {CalculateAge(age)}");
    }
   

    
    
}
