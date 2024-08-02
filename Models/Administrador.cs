using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TransRiwi.Models;

public static class Administrador
{
   
    public static void Menu()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("===============================================");
            Console.WriteLine("                 ADMINISTRADOR                 ");
            Console.WriteLine("===============================================");
            Console.WriteLine("| 1. Mostrar Detalles de Usuario               |");
            Console.WriteLine("| 2. Añadir Experiencia                        |");
            Console.WriteLine("| 3. Actualizar Categoria de la Licencia       |");
            Console.WriteLine("| 4. Actualizar Membresia                      |");
            Console.WriteLine("| 5. Eliminar un vehiculo                      |");
            Console.WriteLine("| 6. Mostrar todos los clientes                |"); 
            Console.WriteLine("| 7. Clientes mayores de 30                    |");
            Console.WriteLine("| 8. Conductores ordenados de forma descendente|");
            Console.WriteLine("| 9. Clientes que paga con tarjeta de credito  |");
            Console.WriteLine("| 10. Conductores con licencia A2              |");
            Console.WriteLine("| 10. Salir                                     |");
            Console.WriteLine("================================================");
            Console.Write("Ingrese una opcion: ");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1: 
                Driver.ShowDetails();                        
                    break;
                case 2:
                Driver.AddDrivingExperience();
                    break;
                case 3:
                Driver.UpdateLicenseCategory();
                    break;
                case 4:
                Customer.UpdateMembershipLevel();
                    break;
                case 5:
                Vehicle.DeleteVehicle();
                     break;
                case 6:
                Customer.ShowCustomers();
                     break;
                case 7:
                Customer.ShowCustomersWithMoreThanThirtyYearsOld();
                     break;
                case 8:
                Driver.ShowDetailsOrderDescending();
                     break;  
                case 9:
                Customer.GetCustomersWithCreditCardPayment();
                break;
                case 10:
                Driver.ListLicenseCategoryA2();
                break;      
                case 11:
                     Console.WriteLine("Gracias por usar nuestro sistema. Adiós...");
                     Thread.Sleep(3000);
                     Environment.Exit(0);
                     break;
                default:
                 Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                 Console.ReadKey();
                 break;


            }
        }  
    }

}
