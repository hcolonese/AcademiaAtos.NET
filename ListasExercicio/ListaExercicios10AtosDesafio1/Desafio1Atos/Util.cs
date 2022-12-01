using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio1Atos
{
    public class Util
    {
        public static string[] QuebraLinha(string linha)
        {
            string[] parametros;
            parametros = linha.Split("-");
            return parametros;
        }
    }
}
