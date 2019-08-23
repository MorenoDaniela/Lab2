using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Title("Ejercicio n 7");

            Console.WriteLine("Ingrese mes  de nacimiento: ");
            string mes = Console.ReadLine();
            int mesN;

            if (int.TryParse(mes, out mesN))
            {
                if (mesN>=1 && mesN<=12)
                {
                    Console.WriteLine("Ingrese  dia de nacimiento: ");
                    string dia = Console.ReadLine();
                    int diaN;

                    if (int.TryParse(dia, out diaN))
                    {
                        if (diaN >= 1 || diaN <= 31)
                        {
                            if (mesN == 2 && diaN > 29)
                            {
                                Console.WriteLine("Error, si el mes es febrero el dia maximo es 29");
                            }

                            /*if (mesN==4 || mesN== 6 || mesN==9 || mesN== 11 && diaN>30)
                            {
                                Console.WriteLine("Error, este mes tiene como maximo 30 dias.");
                            }*/

                            Console.WriteLine("Ingrese año de nacimiento: ");
                            string año = Console.ReadLine();
                            int añoN;

                            if (int.TryParse(año, out añoN))
                            {
                                int diaHoy;
                                int mesHoy;
                                int añoHoy;

                                DateTime diasVividos = DateTime.Now;
                                int.TryParse(diasVividos.ToString("dd"), out diaHoy);
                                int.TryParse(diasVividos.ToString("MM"), out mesHoy);
                                int.TryParse(diasVividos.ToString("yyyy"), out añoHoy);
                                //DateTime.Now.ToString("mm/dd/yyyy");


                                int cantidadDias = 0;

                                for (;añoN<=añoHoy;añoN++)
                                {
                                    if (añoN%4==0 || añoN%400==0)
                                    {
                                        cantidadDias = cantidadDias + 366;
                                    }else
                                    {
                                        cantidadDias = cantidadDias + 365;
                                    }
                                }

                                //cantidadDias = cantidadDias + 234;

                                Console.WriteLine("Cantidad de dias vividos: {0}",cantidadDias);
                            }


                        }
                    }
                }
            }

            Console.ReadKey();
            


        }
    }
}
