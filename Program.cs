using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            Console.WriteLine("Elige una de estas tres categoría: Snaks, Bebidas o Dulces:");
            opcion = Console.ReadLine();
            Console.WriteLine();

            switch (opcion)
            {
                case "Snaks":
                    Console.WriteLine("Acaba de escoger la opción Snaks");
                    Console.WriteLine("Elija una de las opciones que tenemops para tí: PapasLays, Doritos, PiqueoSnax");
                    opcion = Console.ReadLine();

                    if (opcion == "PapasLays")
                    {
                        Console.Write("Acaba de escoger la opción PapasLays, ");
                        Console.Write("el monto a pagar sería de S/. 1.60");
                    }
                    else
                    {
                        if (opcion == "Doritos")
                        {
                            Console.Write("Acaba de escoger la opción Doritos, ");
                            Console.Write("el monto a pagar sería de S/. 2.00");
                        }
                        else
                        {
                            if (opcion == "PiqueoSnax")
                            {
                                Console.Write("Acaba de escoger la opción PiqueoSnax, ");
                                Console.Write("el monto a pagar sería de S/. 3.00");
                            }
                        }
                    }
                    break;

                case "Bebidas":
                    Console.WriteLine("Acaba de escoger la opción Bebidas");
                    Console.WriteLine("Elija una de las opciones que tenemops para tí: CocaCola, Pepsi, InkaCola");
                    opcion = Console.ReadLine();

                    if (opcion == "CocaCola")
                    {
                        Console.Write("Acaba de escoger la opción CocaCola, ");
                        Console.Write("el monto a pagar sería de S/. 1.50");
                    }
                    else
                    {
                        if (opcion == "Pepsi")
                        {
                            Console.Write("Acaba de escoger la opción Pepsi, ");
                            Console.Write("el monto a pagar sería de S/. 1.50");
                        }
                        else
                        {
                            if (opcion == "InkaCola")
                            {
                                Console.Write("Acaba de escoger la opción InkaCola, ");
                                Console.Write("el monto a pagar sería de S/. 1.30");
                            }
                        }
                    }
                    break;

                case "Dulces":
                    Console.WriteLine("Acaba de escoger la opción Dulces");
                    Console.WriteLine("Elija una de las opciones que tenemops para tí: Chicle, Chocolate, Gomitas");
                    opcion = Console.ReadLine();

                    if (opcion == "Chicle")
                    {
                        Console.Write("Acaba de escoger la opción Chicle, ");
                        Console.Write("el monto a pagar sería de S/. 1.00");
                    }
                    else
                    {
                        if (opcion == "Chocolate")
                        {
                            Console.Write("Acaba de escoger la opción Chocolate, ");
                            Console.Write("el monto a pagar sería de S/. 2.00");
                        }
                        else
                        {
                            if (opcion == "Gomitas")
                            {
                                Console.Write("Acaba de escoger la opción Gomitas, ");
                                Console.Write("el monto a pagar sería de S/. 1.60");
                            }
                        }
                    }
                    break;
                default:
                    Console.WriteLine("Categoría no valida");
                    break;
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
