using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio17
{
    class Boligrafo
    {
        public const short cantTintaMax = 100;
        private ConsoleColor _color;
        private short _tinta;

        public Boligrafo() { }

        public Boligrafo(short ink)
        {
            this.SetTinta(ink);
        }

        public Boligrafo(ConsoleColor color, short tinta):this( tinta )
        {
            this._color = color;
        }

        public ConsoleColor GetColor
        {
            get
            {
                return this._color;
            }
        }

        public short GetTinta
        {
            get
            {
                return this._tinta;
            }
        }

        private void SetTinta( short amount )
        {
            if (amount > 0 && (amount + this._tinta <= cantTintaMax))
            {
                this._tinta += amount;
            }
            else if ((amount < 0 && this._tinta - amount >= 0))
            {
                this._tinta -= amount;
            }
        }

        public void Recargar()
        {
            short refill = (short) (cantTintaMax - _tinta);
            this.SetTinta( refill );
        }

        public bool Pintar(int gasto, out string dibujo)
        {
            this.SetTinta((short)(gasto * -1));
           
            dibujo = string.Empty;
            for (int i = 0; i < gasto; i++)
            {
                dibujo += "*";
            }
            return true;
            /*El método Pintar(int, out string) restará la tinta gastada (reutilizar código SetTinta), sin
poder quedar el nivel en negativo, avisando si pudo pintar (nivel de tinta mayor a 0).
También informará mediante el out string tantos "*" como haya podido "gastar" del nivel de
tinta. O sea, si nivel de tinta es 10 y gasto es 2 valdrá "**" y si nivel de tinta es 3 y gasto es
10 "***"*/
        }
    }
}
