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
            Console.WriteLine("| 1. Gestionar Vehiculos                     |");
            Console.WriteLine("| 2. Gestionar Conductores                  |");
            Console.WriteLine("| 3. Gestionar Clientes                     |");
            Console.WriteLine("| 4. Salir                                  |");
            Console.WriteLine("============================================");
            Console.Write("Ingrese una opcion: ");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                    
                    break;
                case 2:
                    
                    break;
                case 3:
                    
                    break;
                case 4:
                   
                    break;
                case 5:

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
