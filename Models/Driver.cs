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

    //metodos
    //UpdateLicenseCategory(string newCategory) void
    //AddExperience(int years)void

}
