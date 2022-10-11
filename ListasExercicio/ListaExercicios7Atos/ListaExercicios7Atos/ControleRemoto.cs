using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios7Atos
{
    public class ControleRemoto
    {
        private Televisao tv;
        public ControleRemoto(Televisao tv)
        {
            this.tv = tv;
        }
        public void AumentarVolume()
        {
            if (tv.Volume < 10)
            {
                tv.Volume++;
            }
            else
                Console.WriteLine("TV está no volume máximo.");

        }
        public void AbaixarVolume()
        {
            if (tv.Volume > 0)
            {
                tv.Volume--;
            }
            else
                Console.WriteLine("TV já está no mudo.");
        }
        public void AumentarCanal()
        {
            if (tv.Canal < 100)
            {
                tv.Canal++;
            }
            else
                tv.Canal = 1;
        }
        public void AbaixarCanal()
        {
            if (tv.Canal > 1)
            {
                tv.Canal--;
            }
            else
                tv.Canal = 100;

        }
        public void TrocarCanal(int canal)
        {
            if (canal > 0 && canal < 100)
            {
                tv.Canal = canal;
            }
            else
                tv.Canal = canal % 100;
        }
        public void InfoTv()
        {
            Console.WriteLine("O canal atual é: "+tv.Canal);
            Console.WriteLine("O volume atual é: " + tv.Volume);
        }
    }
}
