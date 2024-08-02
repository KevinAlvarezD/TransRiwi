using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public class Customer : User
{
    public string MembershipLevel { get; set; }
    public string PreferredPaymentMethod { get; set; }

    //constructor
    public Customer(string name, string lastName, string typeDocument, string identificationNumber, DateOnly birthDate, string email, string phoneNumber, string adreess, string membershipLevel, string preferredPaymentMethod) : base(name, lastName, typeDocument, identificationNumber, birthDate, email, phoneNumber, adreess)
    {
        MembershipLevel = membershipLevel;
        PreferredPaymentMethod = preferredPaymentMethod;
    }

}
