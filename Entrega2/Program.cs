using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entrega2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido al programa, por favor indique que accion desea realizar");
            Console.WriteLine("1:Importar cancion/video.");
            Console.WriteLine("2:Buscar");
            Console.WriteLine("3:Cerrar el programa");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            { case 1:
                    break;
                case 2:
                    break;
                case 3:
                    Console.WriteLine("Gracias por usar el programa");
                    break;
            }
        }
    }
}
