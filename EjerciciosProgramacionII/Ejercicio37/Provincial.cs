using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Provincial:Llamada
    {
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        //Atributos
        protected Franja franjaHoraria;
        //Propiedades
        public float CostoLlamada
        {
            get
            {
                return this.CalcularCosto();
            }
        }
        //Constructores
        public Provincial(Franja miFranja, Llamada llamada)
            : base(llamada.GetDuracion, llamada.GetNumDestino, llamada.GetNumOrigen)
        {
            this.franjaHoraria = miFranja;
        }

        public Provincial(string origen, Franja miFranja, float duracion, string destino)
            : this(miFranja, new Llamada(duracion, destino, origen)) { }
        //Metodos
        public new string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Llamda Provincial Duracion: {0}\nNumero Destino: {1}\nNumero Origen: {2}\nCosto: {3}\nFranja Horaria: {4}", this.duracion, this.numDestino, this.numOrigen, this.CostoLlamada, this.franjaHoraria);
            return s.ToString();
        }

        private float CalcularCosto()
        {
            float costo;
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    costo = this.GetDuracion * (float)0.99;
                    break;
                case Franja.Franja_2:
                    costo = this.GetDuracion * (float)1.25;
                    break;
                case Franja.Franja_3:
                    costo = this.GetDuracion * (float)0.66;
                    break;
                default:
                    costo = 0;
                    break;
            }
            return costo;
        }

    }
}
