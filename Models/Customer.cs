using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Customer : User
{
    public string MembershipLevel { get; set; }
    public string PreferredPaymentMethod { get; set; }

    public static List<Customer> customers = new List<Customer> {
        new Customer("Juan", "Perez", "CC", "1234567890", new DateOnly(1990, 1, 1), "perez@example.com", "1234567890", "Calle 123 #456, San Francisco","Gold", "Efectivo"),
        new Customer("Ana", "Garcia", "CC", "9876543210", new DateOnly(1991, 3, 5), "garcia@example.com", "9876543210", "Calle 478 #128, Manrique","Platinum", "Tarjeta de Credito"),
        new Customer("Pedro", "Lopez", "CC", "0123456789", new DateOnly(1992, 7, 15), "lopez@example.com", "0123456789", "Calle 345 #6, Robledo","Silver", "Cheque"),
        new Customer("Maria", "Martinez", "CC", "9012345678", new DateOnly(1993, 11, 20), "martinez@example.com", "9012345678", "Calle 879 #548, Esmeraldas","Gold", "Efectivo"),
        new Customer("Jose", "Ruiz", "CC", "1234567890", new DateOnly(1994, 5, 1), "ruiz@example.com", "1234567890", "Calle 654 #321, San Antonio","Platinum", "Tarjeta de Credito"),
        new Customer("Angel", "Gomez", "CC", "2345678901", new DateOnly(1995, 9, 17), "gomez@example.com", "2345678901", "Calle 789 #9, Guadalajara","Silver", "Cheque"),
        new Customer("Luis", "Perez", "CC", "3456789012", new DateOnly(1998, 11, 18), "perez@example.com", "3456789012", "Calle 567 #13, Toluca","Gold", "Efectivo"),
    };


    //constructor
    public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adreess, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, adreess)
    {
        MembershipLevel = membershipLevel;
        PreferredPaymentMethod = preferredPaymentMethod;
    }

    //metodos

    //Actualizar MemberShiplevel
    public static void UpdateMembershipLevel(string newLevel){}

}
