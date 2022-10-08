using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Temperatura
    {
        //Classe criada de exemplo nas aulas
        private double celsius;

        public Temperatura()
        {
            this.celsius = 0;
        }

        public double getFahrenheit()
        {
            return ((celsius*9)/5+32);
        }
        public void setCelsius(double fahrenheit)
        {
            this.celsius = ((fahrenheit - 32)*5)/9;
            Console.WriteLine("Temperatura em Celsius é: "+this.celsius);
        }
    }
}
