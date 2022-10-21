using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace ListaExercicios9Atos
{
    internal class Util
    {
        public static void gravarPessoaArquivo(Pessoa pessoa, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, append:true);
            sw.WriteLine(pessoa.Nome+ ";" + pessoa.Email);
            sw.Flush();
            sw.Close();
        }
        public static void SalvarArquivoListaPessoa(List<Pessoa> lista, string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string linha = "";
                string[] splitLinha;
                linha = sr.ReadLine();

                while (linha != null)
                {
                    splitLinha = linha.Split(";");
                    lista.Add(new Pessoa(splitLinha[0], splitLinha[1]));
                    OrdenaListaPessoa(lista);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void OrdenaListaPessoa(List<Pessoa> lista)
        {
            lista.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
        }
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
        public static void gravarEmailArquivo(Email email, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, append: true);
            sw.WriteLine(email.Nome + ";" + email.Dominio);
            sw.Flush();
            sw.Close();
        }
        public static void SalvarArquivoListaEmail(List<Email> lista, string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string linha = "";
                string[] splitLinha;
                linha = sr.ReadLine();

                while (linha != null)
                {
                    splitLinha = linha.Split(";");
                    lista.Add(new Email(splitLinha[0], splitLinha[1]));
                    OrdenaListaEmail(lista);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void OrdenaListaEmail(List<Email> lista)
        {
            lista.Sort(delegate (Email e1, Email e2)
            {
                return e1.Nome.CompareTo(e2.Nome);
            });
        }
        public static bool ExisteEmail(List<Email> lista, Email novo)
        {
            Email email = null;
            email = lista.Find(delegate (Email e) { return e.Nome == novo.Nome; });
            if (email != null)
            {
                if (email.Dominio == novo.Dominio)
                {
                    return true;
                }
            }
            return false;
        }

        public static void EscreverFigurinhArquivo(Figurinha figurinha, string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName, append: true);
            sw.WriteLine(figurinha.Codigo + ";" + figurinha.Selecao + ";" + figurinha.NomeJogador);
            sw.Flush();
            sw.Close();
        }
        public static void LerArquivoEscreveLista(List<Figurinha> lista, string fileName)
        {
            try
            {
                StreamReader sr = new StreamReader(fileName);
                string linha = "";
                string[] splitLinha;
                linha = sr.ReadLine();

                while (linha != null)
                {
                    splitLinha = linha.Split(";");
                    lista.Add(new Figurinha(splitLinha[0], splitLinha[1], splitLinha[2]));
                    OrdenaListaFigurinhas(lista);
                    linha = sr.ReadLine();
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
        public static void CriaFigurinhaNaLista(string filepath,List<Figurinha> lista)
        {
            Figurinha fig;
            string codigo, selecao, jogador;
            Console.WriteLine("Digite as informações da figurinha: ");
            Console.WriteLine("Código:");
            codigo = Console.ReadLine();
            Console.WriteLine("Seleção:");
            selecao = Console.ReadLine();
            Console.WriteLine("Nome do jogador:");
            jogador = Console.ReadLine();
            fig = new Figurinha(codigo, selecao, jogador);
            Util.EscreverFigurinhArquivo(fig, filepath);
            //Adicionando a figurinha na lista tambem
            lista.Add(fig);
            OrdenaListaFigurinhas(lista);
        }
        public static void OrdenaListaFigurinhas(List<Figurinha> lista)
        {
            lista.Sort(delegate (Figurinha f1, Figurinha f2)
            {
                return f1.Codigo.CompareTo(f2.Codigo);
            });
        }
    }
}
