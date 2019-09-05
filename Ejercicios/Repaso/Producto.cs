using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
    class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;

        public string GetMarca()
        {
            return this.marca;
        }

        public float GetPrecio()
        {
            return this.precio;
        }

        public static string MostrarProducto (Producto p)
        {
            string marca = p.GetMarca();
            double precio = p.GetPrecio();
            string codigo = (string)p;
            /*
            string aux = "";
            aux = marca + precio + codigo;
            return aux;*/
            return string.Format("Codigo: {0} Marca {1} Precio{2}", codigo, marca, precio);
        }

        public static explicit operator string (Producto p)
        {
            return p.codigoDeBarra;
        }

        public static bool operator ==(Producto p1, Producto p2)
        {
            bool retorno = false;

            if (p1.marca==p2.marca && p1.codigoDeBarra==p2.codigoDeBarra)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            bool retorno = false;
            if (!(p1 == p2))
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator ==(Producto p1, string marca)
        {
            bool retorno = false;

            if (p1.GetMarca() == marca)
            {
                retorno = true;
            }
            return retorno;
        }

        public static bool operator !=(Producto p1, string marca)
        {
            bool retorno = false;
            if (!(p1==marca))
            {
                retorno = true;
            }
            return retorno;
        }

        public Producto (string marca, string codigo, float precio)
        {
            this.codigoDeBarra = codigo;
            this.precio = precio;
            this.marca = marca;
        }
    }
}
