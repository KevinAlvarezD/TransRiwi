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
            Console.WriteLine("============================================");
            Console.WriteLine("                 ADMINISTRADOR                ");
            Console.WriteLine("============================================");
            Console.WriteLine("| 1. Mostrar Detalles de Usuario            |");
            Console.WriteLine("| 2. Añadir Experiencia                     |");
            Console.WriteLine("| 3. Actualizar Categoria de la Licencia    |");
            Console.WriteLine("| 4. Actualizar Membresia                   |");
            Console.WriteLine("| 5. Calcular Edad de un Cliente            |");
            Console.WriteLine("| 6. Mostrar Experiencia                     |");
            Console.WriteLine("| 7. Mostrar Experiencia                     |");
            Console.WriteLine("| 8. Salir                                  |");
            Console.WriteLine("| 9. Salir                                  |");
            Console.WriteLine("============================================");
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
                /* Customer.CalculateAge(); */

                     break;
                case 6:

                     break;    
                case 7:

                     break;
                case 8:

                     break;  
                default:
                 Console.WriteLine("Opcion invalida. Presione cualquier tecla para continuar...");
                 Console.ReadKey();
                 break;


            }
        }  
    }      

}
