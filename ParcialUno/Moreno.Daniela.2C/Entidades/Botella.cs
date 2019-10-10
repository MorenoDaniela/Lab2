using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades
{
    public abstract class Botella
    {
        protected int capacidadML;
        protected int contenidoML;
        protected string marca;

        public enum Tipo
        {
            Plastico,
            Vidrio
        }


        public int CapacidadLitros
        {
            get { return capacidadML / 1000; }
            //set { capacidad = value; }
        }

        public int Contenido
        {
            get
            {
                return contenidoML;
            }
            set
            {
                contenidoML = value;
            }
        }

        public float PorcentajeContenido
        {
            get
            {
                return (contenidoML*capacidadML)/ 100;
            }
        }

        protected Botella(string marca, int capacidadML, int contenidoML)
        {
            this.marca = marca;
            if (contenidoML<capacidadML)
            {
                this.capacidadML = capacidadML;
                this.contenidoML = contenidoML;
            }else if (capacidadML<contenidoML)
            {
                this.contenidoML = capacidadML;
                this.capacidadML = capacidadML;
            }
            
        }

        public abstract int ServirMedida();

        protected virtual string GenerarInforme()
        {
            StringBuilder cadena = new StringBuilder();
            cadena.AppendFormat("Marca: {0} \n Contenido: {1}\n Capacidad: {2} \n", this.marca, this.Contenido, this.CapacidadLitros);
            return cadena.ToString();
        }

        public override string ToString()
        {
            return this.GenerarInforme();
        
        }



    }
}
