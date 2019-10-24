using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicio30_Autos;

namespace Prueba
{
    class Program
    {
        static void Main(string[] args)
        {
            Competencia MOTO = new Competencia(5, 5, Competencia.TipoCompetencia.Motocross);
            Competencia FORMULA = new Competencia(5, 5, Competencia.TipoCompetencia.F1);

            Motocross motito = new Motocross(1, "Moto", 5);
            AutoF1 auto = new AutoF1(2, "Auto", 3);

           

        }
    }
}
