using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class Aviao
    {
        //Classe criada de exemplo nas aulas
        private string modelo;
        private string marca;
        private float velocidade;
        private float altitude;

        public Aviao(float vel, float alt)
        {
            this.velocidade= vel;
            this.altitude =alt;
        }
        public void Subir(float quant)
        {
            altitude += quant;
            Console.WriteLine("Você subiu " + quant + " metros.");
            Console.WriteLine("Sua altitude atual é: "+altitude);
        }
        public void Descer(float quant)
        {
            altitude -= quant;
            Console.WriteLine("Você desceu "+quant+" metros.");
            Console.WriteLine("Sua altitude atual é: " + altitude);
        }
        public void Acelerar(float quant)
        {
            velocidade += quant;
            Console.WriteLine("Você acelerou " + quant + " km/h.");
            Console.WriteLine("Sua velocidade atual é: " + velocidade);
        }
        public void Reduzir(float quant)
        {
            velocidade -= quant;
            Console.WriteLine("Você reduziu " + quant + " km/h.");
            Console.WriteLine("Sua velocidade atual é: " + velocidade);
        }
    }
}
