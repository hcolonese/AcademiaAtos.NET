namespace MetodosLists
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> pessoas;
            pessoas = new List<Pessoa>();
            pessoas.Add(new Pessoa("Carlos", 30));
            pessoas.Add(new Pessoa("Joao", 25));
            pessoas.Add(new Pessoa("Eduarda", 57));
            foreach (Pessoa pessoa in pessoas)
            {
                Console.WriteLine(pessoa.Nome + " " + pessoa.Idade);
            }
            Console.WriteLine();
            ListaNaoOrdenada(pessoas);
            ListaOrdenadaNome(pessoas);
            ListaOrdenadaIdade(pessoas);
            ListaInserirPosicao(pessoas, 2, "Zeca", 81);
            ListaInserirPosicao(pessoas, 2, "Mario Alberto", 67);
            ListaOrdenadaIdade(pessoas);
            List<Pessoa> ate50 = ListaLocalizaIdadeAte(pessoas, 50);
            ListaOrdenadaIdade(ate50);

        }
        public static void ListaNaoOrdenada(List<Pessoa> people)
        {
            Console.WriteLine("Imprimindo lista não ordenada");
            people.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
            Console.WriteLine();
        }
        public static void ListaOrdenadaNome(List<Pessoa> people)
        {
            people.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Nome.CompareTo(p2.Nome);
            });
            Console.WriteLine("Imprimindo Lista Ordenada Nome");
            people.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
            Console.WriteLine();
        }
        public static void ListaOrdenadaIdade(List<Pessoa> people)
        {
            people.Sort(delegate (Pessoa p1, Pessoa p2)
            {
                return p1.Idade.CompareTo(p2.Idade);
            });
            Console.WriteLine("Imprimindo Lista Ordenada Idade");
            people.ForEach(delegate (Pessoa p)
            {
                Console.WriteLine(p.Nome + " " + p.Idade);
            });
            Console.WriteLine();
        }

        public static void ListaInserirPosicao(List<Pessoa> people, int pos, string nome, int idade)
        {
            people.Insert(pos, new Pessoa(nome, idade));
        }
        public static List<Pessoa> ListaLocalizaIdadeAte(List<Pessoa> people, int idade)
        {
            List<Pessoa> jovems = people.FindAll(delegate (Pessoa p) { return p.Idade < idade; });
            return jovems;
        }
    }
}