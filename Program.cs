using System;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;
using System.IO;

namespace Aplicacion14toBim
{
    class Program
    {
        static void Main(string[] args)
        {
            int op = 0;

            while (op!=2)
            {
                Console.Clear();
                Console.WriteLine("----------------------------------------------");
                Console.WriteLine("-------Cinta De Opciones-------");
                Console.WriteLine("\n1. Crear Archivo \n2. Salir ");
                Console.WriteLine("Digite el numero de opcion que desea");
                Console.WriteLine("----------------------------------------------");
                op = int.Parse(Console.ReadLine());
              
                Console.Clear();

                if (op == 1)
                {
                    Console.WriteLine("Ingrese el Nombre del archivo");
                    String archivo = Console.ReadLine() + ".txt";
                    StreamWriter ar;
                    ar = File.AppendText(archivo);
                    Console.WriteLine("Escribe algo");
                    ar.WriteLine(Console.ReadLine());
                    ar.WriteLine(".............");
                    ar.Close();  
                }
                else if (op == 2)
                {
                    break;
                }
            }
            Console.ReadKey();
        }
    }
}
