using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_16
{
    class Alumno
    {
        byte nota1;
        byte nota2;
        float notaFinal;
        string apellido;
        int legajo;
        string nombre;

        public  Alumno(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar (byte notaUno, byte notaDos)
        {
            this.nota1 = notaUno;
            this.nota2 = notaDos;
        }

        public void CalcularFinal()
        {
            Random numero = new Random();//random se utiliza para crear numeros random
            if (this.nota1>=4 && this.nota2>=4)
            {
                this.notaFinal = numero.Next(0, 10);//a next se le pasa los parametros de minimo y maximo para el random
            }else
            {
                this.notaFinal = -1;
            }

            /* system Treading. Tread.Sleep(seg puede ser 150 o 200);
             * new*/
        }

        public void Mostrar()
        {
            Console.WriteLine("Nombre: {0} Apellido {1} Legajo: {2} ", this.nombre, this.apellido, this.legajo);
            Console.WriteLine("Nota uno: {0} Nota dos: {1} ", this.nota1, this.nota2);
            if (this.notaFinal!=-1)
            {
                Console.WriteLine("Nota final: {0}", this.notaFinal);
            }else
            {
                Console.WriteLine("Alumno desaprobado.");
            }
        }
    }
}
