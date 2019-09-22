using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConvertirCentigradosAFarenheit
{
    public class Convertidor
    {

        private double centigrados;
        private double fahrenheit;

        public void setCentigrados(double valor)
        {
            this.centigrados = valor;
        }

        public double getCentigrados()
        {
            return this.centigrados;
        }

        public double convertir()
        {
            return ((this.getCentigrados()*9/5)+32);
        }

    }
}
