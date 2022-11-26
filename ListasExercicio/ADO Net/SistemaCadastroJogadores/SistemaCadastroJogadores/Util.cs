using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaCadastroJogadores
{
    public class Util
    {
        
        public static bool ExistePessoa(List<Pessoa> lista, string nome)
        {
            Pessoa p = null;
            p = lista.Find(delegate (Pessoa p) { return p.Nome == nome; });
            if (p == null)
            {
                return false;
            }
            return true;
        }
        public static void OrdenaListaPessoa(List<Pessoa> lista)
        {
            lista.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
        }
        public static void WritePeopleToFile(Pessoa pessoa, string fileName)
        {
            
            StreamWriter sw = new StreamWriter(fileName, append: true);
            sw.WriteLine(pessoa.Nome + ";" + pessoa.Email);
            sw.Flush();
            sw.Close();
        }
        internal static void WriteFileToList(List<Pessoa> listaPessoas, string filePath)
        {
            try
            {
                StreamReader sr = new StreamReader(filePath);
                string linha = "";
                string[] splitLinha;
                linha = sr.ReadLine();

                while (linha != null)
                {
                    splitLinha = linha.Split(";");
                    listaPessoas.Add(new Pessoa(splitLinha[0], splitLinha[1]));
                    OrdenaListaPessoa(listaPessoas);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
