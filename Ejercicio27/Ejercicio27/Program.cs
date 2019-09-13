using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> numeros = new List<int>();
            Queue<int> numq = new Queue<int>();
            Stack<int> nums = new Stack<int>();
            int i;

            Random random = new Random();
            //int randomNumber = random.Next(-100, 100);
            List<int> positivos = new List<int>();
            List<int> negativos = new List<int>();
            Queue<int> positivosQ = new Queue<int>();
            Queue<int> negativosQ = new Queue<int>();
            Stack<int> positivosS = new Stack<int>();
            Stack<int> negativosS = new Stack<int>();

            for (i = 0; i < 20; i++)
            {
                int randomNumber = random.Next(-100, 100);

                if (randomNumber != 0)
                {
                    numq.Enqueue(randomNumber);
                    nums.Push(randomNumber);
                    numeros.Add(randomNumber);
                    Console.WriteLine("{0} ", randomNumber);
                }
                else
                    i--;


                if (randomNumber > 0)
                {
                    positivos.Add(randomNumber);
                    positivosS.Push(randomNumber);
                    positivosQ.Enqueue(randomNumber);

                }
                else
                {
                    negativosS.Push(randomNumber);
                    negativosQ.Enqueue(randomNumber);
                    negativos.Add(randomNumber);

                }
            }

            positivos.Sort();
            positivosQ = new Queue<int>(positivosQ.OrderByDescending(q => q));
            positivosS= new Stack<int> (positivosS.OrderBy(q => q));//preguntar que hace ahre

            negativosS= new Stack<int>(negativosS.OrderByDescending(q => q));
            negativosQ = new Queue <int> (negativosQ.OrderBy(q => q));
            negativos.Sort();

            positivos.Reverse();
            positivosS.Reverse();

            Console.WriteLine("\nPOSITIVOS LISTA");
            foreach (int num in positivos)
            {
                Console.WriteLine("{0} ", num);
            }
            Console.WriteLine("\nPOSITIVOS PILA");
            foreach (int num in positivosS)
            {
                Console.WriteLine("{0} ", num);
            }
            Console.WriteLine("\nPOSITIVOS COLA");
            foreach (int num in positivosQ)
            {
                Console.WriteLine("{0} ", num);
            }

            Console.WriteLine("NEGATIVOS \n");
            foreach (int num2 in negativos)
            {

                Console.WriteLine("{0} ", num2);
            }
            Console.WriteLine("NEGATIVOS PILA\n");
            foreach (int num2 in negativosS)
            {

                Console.WriteLine("{0} ", num2);
            }
            Console.WriteLine("NEGATIVOS COLA\n");
            foreach (int num2 in negativosQ)
            {

                Console.WriteLine("{0} ", num2);
            }

            Console.ReadKey();
        }

    }
}
