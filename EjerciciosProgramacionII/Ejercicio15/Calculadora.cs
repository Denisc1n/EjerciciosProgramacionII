using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio15
{
    class Calculadora
    {
        public static decimal Calcular( decimal num1, decimal num2, string operation)
        {
            decimal retValue = 0;
            switch (operation)
            {
                case "+":
                    retValue=  num1 + num2;
                    break;
                case "-":
                    retValue = num1 - num2;
                    break;
                case "*":
                    retValue = num1 * num2;
                    break;
                case "/":
                    if (!Validar(num2))
                    {
                        retValue = 0;
                        break;
                    }
                    retValue = num1 / num2;
                    break;
                default:
                    retValue = 0;
                    break;
            }
            return retValue;
        }
        private static bool Validar(decimal num)
        {
            if (num <= 0) return false;

            return true;
        }

    }
}
