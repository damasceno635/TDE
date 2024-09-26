using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gerencia_Tarefas
{
    class Program
    {
        static List<Tarefa> task = new List<Tarefa>();
        static void Main(string[] args)
        {
            bool sair = true;

            while (sair)
            {
                Console.Clear();
                Console.WriteLine("\nGerenciamento de Tarefas Pessoais - MENU:");
                Console.WriteLine("1 - Adicionar tarefa");
                Console.WriteLine("2 - Listar tarefas");
                Console.WriteLine("3 - Remover tarefa");
                Console.WriteLine("4 - Editar tarefa");
                Console.WriteLine("5 - Sair");
                Console.Write("\nEscolha uma opção: ");

                string opcao = Console.ReadLine();
                switch (opcao)
                {
                    case "1":
                        Console.Clear();
                        AddTask();
                        break;
                    case "2":
                        Console.Clear();
                        ListTask();
                        break;
                    case "3":
                        Console.Clear();
                        RemoveTask();
                        break;
                    case "4":
                        Console.Clear();
                        EditTask();
                        break;
                    case "5":
                        sair = false;
                        break;
                    default:
                        Console.WriteLine("\nOpção Inválida !");
                        Console.Write("\nPessione 'enter' para escolher novamente.");
                        Console.ReadLine();
                        break;
                }
            }
        }

        // Adicionar Tarefa
        static void AddTask()
        {
            Console.Write("\nDigite o título: ");
            string titulo = Console.ReadLine();
            Console.Write("Digite a descrição: ");
            string descricao = Console.ReadLine();
            Console.Write("Digite o prazo: ");
            string prazo = Console.ReadLine();
            Console.Write("Digite o andamento: ");
            string andamento = Console.ReadLine();

            Tarefa nTask = new Tarefa(titulo, descricao, prazo, andamento);
            task.Add(nTask);
            Console.WriteLine("\nTarefa adicionada com sucesso !");
            Console.Write("\nPessione 'enter' para voltar ao menu.");
            Console.ReadLine();
        }
        
        // Listar Tarefas
        static void ListTask()
        {
            if (task.Count != 0)
            {
                Console.WriteLine("\nTarefas salvas: ");
                foreach (var task in task)
                {
                    Console.WriteLine(task.Conceito());
                }
                Console.Write("\nPessione 'enter' para voltar ao menu.");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("\nNão há tarefas cadastradas ainda!");
                Console.Write("\nPessione 'enter' para voltar ao menu.");
                Console.ReadLine();
            }
        }

        // Remover Tarefa
        static void RemoveTask()
        {
            if (task.Count != 0)
            {
                Console.Write("Digite o título da tarefa que deseja remover: ");
                string title = Console.ReadLine();

                Tarefa nTask = task.Find(Tarefa => Tarefa.TituloConteudo == title);
                {
                    if (nTask != null)
                    {
                        task.Remove(nTask);
                        Console.WriteLine("\nTarefa removida com sucesso !");
                        Console.Write("\nPessione 'enter' para voltar ao menu.");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("\nTarefa não encontrada !");
                        Console.Write("\nPessione 'enter' para voltar ao menu.");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNão há tarefas cadastradas ainda !");
                Console.Write("\nPessione 'enter' para voltar ao menu.");
                Console.ReadLine();
            }
        }

        // Editar Tarefa
        static void EditTask()
        {
            if (task.Count != 0)
            {
                Console.Write("Digite o título da tarefa que deseja editar: ");
                string title = Console.ReadLine();

                Tarefa nTask = task.Find(Tarefa => Tarefa.TituloConteudo == title);
                foreach (var tasks in task)
                {
                    if (nTask != null)
                    {
                        Console.Write("Digite a nova descrição: ");
                        nTask.DescricaoConteudo = Console.ReadLine();
                        Console.Write("Digite o novo prazo: ");
                        nTask.PrazoConteudo = Console.ReadLine();
                        Console.Write("Digite o novo andamento: ");
                        nTask.AndamentoConteudo = Console.ReadLine();

                        Console.WriteLine("\nTarefa editada com sucesso !");
                        Console.Write("\nPessione 'enter' para voltar ao menu.");
                        Console.ReadLine();
                    }

                    else
                    {
                        Console.WriteLine("\nTarefa não encontrada !");
                        Console.Write("\nPessione 'enter' para voltar ao menu.");
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                Console.WriteLine("\nNão há tarefas cadastradas ainda!");
                Console.Write("\nPessione 'enter' para voltar ao menu.");
                Console.ReadLine();
            }
        }
    }
}