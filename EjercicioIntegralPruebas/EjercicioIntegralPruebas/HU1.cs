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
                if (nivel <= 8.25)
                    resultado = "AZUL";
                else if (nivel <= 15)
                    resultado = "AMARILLO";
                else
                    resultado = "ROJO";
            }
            return resultado;
        }
    }


    public class HU2
    {
        public double ObtenerGradoToxicidad(Elemento elemento)
        {
            double resultado = 0;

            //VALOR PH
            if ((int)elemento.PH.ValorRecibido == 7 || (int)elemento.PH.ValorRecibido == 6)
                elemento.PH.ValorPonderado = (int)elemento.PH.ValorRecibido;

            ////VALOR NP
            if ((string)elemento.NP.ValorRecibido == "10-20")
                elemento.NP.ValorPonderado = 8;
            if ((string)elemento.NP.ValorRecibido == "20-30")
                elemento.NP.ValorPonderado = 6;

            ////VALOR Concentración
            if ((string)elemento.CN.ValorRecibido == "ALTA")
                elemento.CN.ValorPonderado = 20;
            if ((string)elemento.CN.ValorRecibido == "BAJA")
                elemento.CN.ValorPonderado = 10;
            if ((string)elemento.CN.ValorRecibido == "MEDIA")
                elemento.CN.ValorPonderado = 15;

            ////VALOR Acidez
            if ((string)elemento.Acidez.ValorRecibido == "BÁSICO")
                elemento.Acidez.ValorPonderado = 2;
            if ((string)elemento.Acidez.ValorRecibido == "ALCALINO")
                elemento.Acidez.ValorPonderado = 4;

            ////VALOR Acidez
            if ((string)elemento.Tipo.ValorRecibido == "MTP")
                elemento.Tipo.ValorPonderado = 5;
            if ((string)elemento.Tipo.ValorRecibido == "HOMEOPÁTICO")
                elemento.Tipo.ValorPonderado = 3;

            ////VALOR Acidez
            if ((string)elemento.Composicion.ValorRecibido == "ACTIVO")
                elemento.Composicion.ValorPonderado = 2;
            if ((string)elemento.Composicion.ValorRecibido == "EXCIPIENTE")
                elemento.Composicion.ValorPonderado = 4;

            resultado = (((int)elemento.PH.ValorPonderado + (int)elemento.NP.ValorPonderado) + ((int)elemento.CN.ValorPonderado * (int)elemento.Acidez.ValorPonderado)) / (int)elemento.Tipo.ValorPonderado + (int)elemento.Composicion.ValorPonderado;

            return resultado;
        }
    }

    public class Elemento
    {
        private Propiedad ph;
        private Propiedad np;
        private Propiedad cn;
        private Propiedad acidez;
        private Propiedad tipo;
        private Propiedad composicion;
        public Propiedad PH { get { return ph; } set { ph = value; } }
        public Propiedad NP { get { return np; } set { np = value; } }
        public Propiedad CN { get { return cn; } set { cn = value; } }
        public Propiedad Acidez { get { return acidez; } set { acidez = value; } }
        public Propiedad Tipo { get { return tipo; } set { tipo = value; } }
        public Propiedad Composicion { get { return composicion; } set { composicion = value; } }
    }

    public class Propiedad
    {
        private object ponderado;
        private object recibido;
        public object ValorPonderado { get { return ponderado; } set { ponderado = value; } }
        public object ValorRecibido { get { return recibido; } set { recibido = value; } }
    }
}
