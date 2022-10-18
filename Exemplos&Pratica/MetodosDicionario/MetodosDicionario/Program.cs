namespace MetodosDicionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exemplo 1, dicionário simples
            //Dictionary<int,string> dic1 =  new Dictionary<int, string>()
            //{
            //    {1,"Banana"},
            //    {2,"Laranja"},
            //    {3,"Manga"},
            //    {4,"Abacaxi"},
            //    {5,"Uva"}
            //};
            //KeyValuePair<int, string> par1 = new KeyValuePair<int, string>(3,"Manga");

            ////Impressão de alguns
            //Console.WriteLine(dic1[2]);
            //Console.WriteLine(dic1[4]);

            ////Impressão de todos
            //foreach (KeyValuePair<int,string> item in dic1)
            //{
            //    Console.WriteLine(item.Key + " - " + item.Value);
            //}

            ////Verificando se contém com métodos diferentes
            //Console.WriteLine(dic1.ContainsValue("Manga"));
            //Console.WriteLine(dic1.Contains(par1));
            //Console.WriteLine(dic1.ContainsKey(3));

            ////Remoção com métodos diferentes
            //dic1.Remove(1);
            //string fruta;
            //dic1.Remove(3, out fruta);
            //Console.WriteLine("fruta removida foi: "+fruta);

            //If com containsKey
            //if (dic1.ContainsKey(1))
            //{
            //    Console.WriteLine(dic1[1]);
            //}
            //else
            //    Console.WriteLine("Valor não encontrado");

            //If com TryGet
            //string resultado;
            //if(dic1.TryGetValue(3, out resultado))
            //{
            //    Console.WriteLine(resultado);
            //}
            //else
            //    Console.WriteLine("Valor não encontrado");

            //Exemplo 2, dicionário ordenado
            //Ele ordena pela chave
            SortedDictionary<string, int> dic2 = new SortedDictionary<string, int>();
            dic2.Add("Zebra",8);
            dic2.Add("Cachorro",10);
            dic2.Add("Gato",4);
            dic2.Add("Pardal",6);
            dic2.Add( "C#",100);
            foreach (KeyValuePair<string, int> item in dic2)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

        }
    }
}