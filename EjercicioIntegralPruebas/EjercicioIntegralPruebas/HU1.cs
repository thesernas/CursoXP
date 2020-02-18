using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioIntegralPruebas
{
    public class HU1
    {
        public string ObtenerNivelToxicidad(double nivel)
        {
            string resultado = string.Empty;

            if (nivel <= 3.8)
                resultado = "VERDE";
            else
            {
                if(nivel <= 8.25)
                    resultado = "AZUL";
                else if(nivel <= 15)
                    resultado = "AMARILLO";
                else
                    resultado = "ROJO";
            }
            return resultado;
        }
    }
}
