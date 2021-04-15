using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Evaluacion1_Programacion
{
    /* 
     Ballot issuance system, in which you must store the data of said ballots, the storage will be through the use of arrangements, the
     number of tickets will be delimited by a while loop, asking the operator if he wants to continue entering or not, more data.
     After entry, the system must display the following statistics.
    • Ballot with Higher Value to Pay. (You can use MAX function)
    • Ballot with Lower Value to Pay. (You can use MIN function)
    • Show All Ballots issued.
    • Show All Ballots with folio rank, from number 1 to number 10.
    • Show All Ballot records with a total to pay less than 1000.
    • Show All Ballot records with a total to pay greater than 10,000. 
     */
    class Program
    {
        static void Main(string[] args)
        {
            string pivot; //for the parsing        
            DateTime date = DateTime.Now;
            char resp = 'S';
            int size;
            int i = 0;
            int t;
            Console.WriteLine("Ingrese la cantidad de boletas: ");
            pivot = Console.ReadLine();
            size = Int32.Parse(pivot);
            int[] ticket = new int[size];
            string[] target = new string[size];
            float maximum = 0;
            float minimum = 0;
            int opc = 99;

            while (resp != 'N')
            {
                Console.WriteLine("___________________________");
                Console.WriteLine("Estamos en la vuelta: " + i);
                Console.WriteLine("Ingrese monto de la boleta: ");
                pivot = Console.ReadLine();
                ticket[i] = Int32.Parse(pivot);
                Console.Write("¿Debito o Credito? : ");
                target[i] = Console.ReadLine();
                Console.WriteLine("¿Desea seguir ingresando montos en las boletas S / N ?");
                pivot = Console.ReadLine();
                resp = char.Parse(pivot);
                i ++;
                Console.WriteLine("_________________________");                
            }
            t = i;

            while (opc != 0)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine(".:: MENU DE OPCIONES::.");
                Console.WriteLine(".:: INGRESE UNA OPCION::.");
                Console.WriteLine(".:: 1- Boleta a pagar mas alto::.");
                Console.WriteLine(".:: 2- Boleta a pagar mas bajo::.");
                Console.WriteLine(".:: 3- Mostrar Todas las Boletas emitidas::.");
                Console.WriteLine(".:: 4 -Mostrar Todas las Boletas con rango de folio, desde la numero 1 hasta la numero 10::.");
                Console.WriteLine(".:: 5 -Mostrar Todos los registros de Boletas con un total a pagar inferior a 1000.::.");
                Console.WriteLine(".:: 6 -Mostrar Todos los registros de Boletas con un total a pagar Mayor a 10000.::");
                Console.WriteLine(".:: 0 - Salir.::");
                Console.WriteLine(".:: INGRESE OPCION: ::.");
                pivot = Console.ReadLine();
                opc = Int32.Parse(pivot);
                Console.WriteLine("_________________________");

                switch (opc)
                {
                    case 1:
                        maximum = ticket.Max();                        
                        Console.WriteLine("La boleta con el mayor valor es de " + maximum);
                        Console.WriteLine("Fecha de la boleta:" + date);
                        break;
                    case 2:
                        minimum = ticket.Min();
                        Console.WriteLine("La boleta con el menor valor es de " + minimum);
                        Console.WriteLine("Fecha de la boleta:" + date);

                        break;
                    case 3:
                        for (i = 0; i < t; i++)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine("..::Datos de Salida::..");
                            Console.WriteLine("TODAS LAS BOLETAS:  ");
                            Console.WriteLine("Numero de Folio: F" + i);
                            Console.WriteLine("Total de la boleta: " + ticket[i]);
                            Console.WriteLine("Modo de pago : " + target[i]);
                            Console.WriteLine("Fecha de la boleta:" + date);
                            Console.WriteLine("______________________");
                        }
                        break;
                    case 4:
                        for (i = 0; i < t; i++)
                        {

                            if (i <= 9)
                            {
                                Console.WriteLine("_________________________");
                                Console.WriteLine("..::Datos de Salida::..");
                                Console.WriteLine("Las boletas con Folio del 1 al 10: ");
                                Console.WriteLine("Numero de Folio: F" + i);
                                Console.WriteLine("Total de la boleta: " + ticket[i]);
                                Console.WriteLine("Modo de pago : " + target[i]);
                                Console.WriteLine("Fecha de la boleta:" + date);
                                Console.WriteLine("______________________");
                            }
                        }
                        break;

                    case 5:

                        for (i = 0; i < t; i++)
                        {
                            if (ticket[i] >= 0 && ticket[i] <= 1000)
                            {
                                Console.WriteLine("_________________________");
                                Console.WriteLine("Boletas con un monto menor a 1000: ");
                                Console.WriteLine("Numero de Folio: F" + i);
                                Console.WriteLine("Total de la boleta: " + ticket[i]);
                                Console.WriteLine("Fecha de la boleta:" + date);
                                Console.WriteLine("Modo de pago : " + target[i]);
                                Console.WriteLine("_________________________");
                            }
                }
                        break;

                    case 6:

                        for (i = 0; i < t; i++)
                        {  
                            if (ticket[i] >= 10000)
                        {
                            Console.WriteLine("_________________________");
                            Console.WriteLine("Boletas con un monto Mayor a 10000: ");
                            Console.WriteLine("Numero de Folio: F" + i);
                            Console.WriteLine("Total de la boleta: " + ticket[i]);
                            Console.WriteLine("Fecha de la boleta:" + date);
                            Console.WriteLine("Modo de pago : " + target[i]);
                            Console.WriteLine("_________________________");
                            }
                        }
                        break;
                    default:
                        Console.WriteLine("Ingrese opcion valida");
                        break;
                }

            }          
          
               
            
        }
    }
}
