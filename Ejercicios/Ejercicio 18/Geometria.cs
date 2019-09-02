using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometria
{
    public class Rectangulo
    {
        private float area;
        private float perimetro;
        private Punto vertice1;
        private Punto vertice2;
        private Punto vertice3;
        private Punto vertice4;

        public float Area()
        {
            float bas = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.area = bas * altura;
            return this.area;
        }
            
        public float Perimetro()
        {
            float bas = Math.Abs(this.vertice1.GetX() - this.vertice3.GetX());
            float altura = Math.Abs(this.vertice1.GetY() - this.vertice3.GetY());
            this.perimetro = (bas + altura) * 2;
            return this.perimetro;
        }
            
        public  void UnRectangulo (Punto vertice1, Punto vertice3)
        {
            Punto punto2 = new Punto();
            Punto punto4 = new Punto();
            punto2.UnPunto(vertice1.GetX(),vertice3.GetY());
            punto4.UnPunto(vertice3.GetX(), vertice1.GetY());
            this.vertice1 = vertice1;
            this.vertice3 = vertice3;
            this.vertice2 = punto2;
            this.vertice4 = punto4;
            
        }
    }

    public class Punto
    {
        private int x;
        private int y;

        public void UnPunto(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetX()
        {
            return this.x;
        }

        public int GetY()
        {
            return this.y;
        }

    }

    /*
    public void Mostrar (Rectangulo unrectangulo)
    {
        Console.WriteLine("Area {0}", unrectangulo.Area());
        Console.WriteLine("Perimetro {0}", unrectangulo.Perimetro());
        
    }*/
}
