﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio37
{
    public class Centralita
    {
        private List<Llamada> listaDeLlamadas;
        protected string razonSocial;

        #region Properties

        public float GananciasLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Local);
            }
        }

        public float GananciasProvincial
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Provincial);
            }
        }

        public float GananciasTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLlamada.Todas);
            }
        }

        public List<Llamada> Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion

        #region Constructores

        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
        }

        public Centralita(string nombreEmpresa)
            : this()
        {
            this.razonSocial = nombreEmpresa;
        }


        #endregion

        #region Methods

        private float CalcularGanancia( Llamada.TipoLlamada tipoLlamada)
        {
            float valorRecaudado = 0;

            switch (tipoLlamada)
            {
                case Llamada.TipoLlamada.Local:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Provincial:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                    }
                    break;
                case Llamada.TipoLlamada.Todas:
                    foreach (Llamada llamada in this.listaDeLlamadas)
                    {
                        if (llamada is Provincial)
                        {
                            valorRecaudado += ((Provincial)llamada).CostoLlamada;
                        }
                        if (llamada is Local)
                        {
                            valorRecaudado += ((Local)llamada).CostoLlamada;
                        }
                    }
                    break;
                default:
                    break;
            }
            return valorRecaudado;
        }

        public string Mostrar()
        {
            StringBuilder s = new StringBuilder();
            s.AppendFormat("Razon Social: {0}\nGanancia Total: {1}\nGanancia Locales: {2}\nGanancia Provinciales: {3}\n", this.razonSocial, this.GananciasTotal, this.GananciasLocal, this.GananciasProvincial);

            foreach (Llamada llamada in this.listaDeLlamadas)
            {
                s.AppendLine("Detalle de llamadas:" + llamada.Mostrar());
            }
            return s.ToString();
        }

        public void OrdenarLlamadas()
        {
            this.listaDeLlamadas.Sort(Llamada.OrdenarPorDuracion);
        }

        #endregion
    }
}
