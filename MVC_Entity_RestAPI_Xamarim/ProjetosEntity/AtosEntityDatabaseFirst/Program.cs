using Microsoft.EntityFrameworkCore;

namespace AtosEntityDatabaseFirst
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atos Entity DataBaseFirst!");

            Console.WriteLine("Digite: \n" +
                "1 para criar uma pessoa\n" +
                "2 para alterar o nome da pessoa\n" +
                "3 para inserir um email\n" +
                "4 para excluir uma pessoa\n" +
                "5 para consultar tudo\n" +
                "6 para consultar pelo ID\n");
            int op = int.Parse(Console.ReadLine());
            Contexto contexto = new Contexto();
            switch (op)
            {
                case 1:
                    try
                    {
                        Console.WriteLine("Digite o nome da pessoa:");
                        Pessoa p = new Pessoa();
                        p.Nome = Console.ReadLine();

                        Console.WriteLine("Digite o um email:");
                        string emailTemp = Console.ReadLine();
                        p.Emails = new List<Email>()
                        {
                            new Email()
                            {
                                email = emailTemp
                            }
                        };

                        contexto.Pessoas.Add(p);
                        contexto.SaveChanges();

                        Console.WriteLine("Pessoa inserida com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 2:
                    try
                    {
                        Console.Write("Informe o ID da Pessoa:");
                        int id = int.Parse(Console.ReadLine());

                        Pessoa pAlt = contexto.Pessoas.Find(id);
                        Console.WriteLine("Informe o novo nome:");
                        pAlt.Nome = Console.ReadLine();

                        contexto.Pessoas.Update(pAlt);
                        contexto.SaveChanges();

                        Console.WriteLine("Nome atualizado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 3:
                    try
                    {
                        Console.Write("Informe o ID da Pessoa:");
                        int idEmail = int.Parse(Console.ReadLine());
                        Pessoa pEmail = contexto.Pessoas.Find(idEmail);

                        Console.WriteLine("Informe o novo email:");
                        string emTemp = Console.ReadLine();
                        pEmail.Emails = new List<Email>()
                    {
                        new Email()
                        {
                            email = emTemp
                        }
                    };

                        contexto.Pessoas.Update(pEmail);
                        contexto.SaveChanges();
                        Console.WriteLine("Email adicionado com sucesso!");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 4:
                    try
                    {
                        Console.Write("Informe o ID da Pessoa:");
                        int id = int.Parse(Console.ReadLine());
                        Pessoa p = contexto.Pessoas.Find(id);
                        Console.WriteLine("Confirmar a exclusão de " + p.Nome);
                        Console.WriteLine("E dos seus emails: ");

                        foreach (Email item in p.Emails)
                        {
                            Console.WriteLine("\t" + item.email);
                        }
                        Console.WriteLine("1 para SIM e outra tecla para NÃO");
                        if (int.Parse(Console.ReadLine()) == 1)
                        {
                            Console.WriteLine("Pessoa " + p.Nome + " excluída com sucesso!");
                            contexto.Pessoas.Remove(p);
                            contexto.SaveChanges();
                        }
                        else
                        {
                            return;
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 5:
                    try
                    {
                        //Consulta na linguagem LINQ
                        List<Pessoa> lista = (from Pessoa p in contexto.Pessoas
                                              select p).Include(pes => pes.Emails).ToList<Pessoa>();
                        foreach (Pessoa pessoa in lista)
                        {
                            Console.WriteLine(pessoa.Nome);
                            foreach (Email itemE in pessoa.Emails)
                            {
                                Console.WriteLine("\t" + itemE.email);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
                case 6:
                    try
                    {
                        Console.Write("Informe o ID da Pessoa:");
                        int idFiltro = int.Parse(Console.ReadLine());

                        Pessoa p = contexto.Pessoas.Include(pes => pes.Emails)
                            .FirstOrDefault(pessoa => pessoa.Id == idFiltro);
                        Console.WriteLine("Nome: " + p.Nome);
                        if (p.Emails != null)
                        {
                            foreach (Email item in p.Emails)
                            {
                                Console.WriteLine("\t" + item.email);
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                    break;
            }
        }
    }
}
