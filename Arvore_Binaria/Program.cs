using System;

namespace Arvore_Binaria
{
    class Program
    {
        static Random rnd = new Random();
        static ArvoreBinaria arvore = new ArvoreBinaria();

        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.WriteLine("--------------MENU--------------");
            Console.WriteLine();
            Console.WriteLine("Qual operação deseja fazer?(I - inserir / R - remover / C - consultar) ");
            char opcao = char.Parse(Console.ReadLine().ToUpper());
            Console.WriteLine();

            if (opcao == 'I')
                Inserir();

            else if (opcao == 'C')
                Consultar();
            else if (opcao == 'R')
                Remover();
            else
            {
                Console.Clear();
                Console.WriteLine("<<<<<Opção invalida!>>>>>");
                Console.WriteLine();
                Menu();
            }
        }
        static void Inserir()
        {
            Console.WriteLine("Qual o valor que deseja incluir?");
            int valor = int.Parse(Console.ReadLine());
            arvore.Inserir(valor);

            Console.WriteLine("Deseja adicionar um novo valor? (S - sim / N - nao)");
            char novaInsercao = char.Parse(Console.ReadLine().ToUpper());

            if (novaInsercao == 'S')
            {
                Console.Clear();
                Inserir();
            }

            else
            {
                Console.Clear();
                Menu();
            }

            ////Valores para demonstração do projeto;
            //arvore.Inserir(65);
            //arvore.Inserir(13);
            //arvore.Inserir(84);
            //arvore.Inserir(42);
            //arvore.Inserir(69);
            //arvore.Inserir(91);
            //arvore.Inserir(24);
            //arvore.Inserir(96);
            //arvore.Inserir(1);
            //arvore.Inserir(73);

            ////Inserir valores random;
            //for (var i = 0; i < 10; i++)
            //{
            //    var val = rnd.Next(1, 999);
            //    arvore.Inserir(val);
            //}
        }
        static void Consultar()
        {
            Console.WriteLine("Qual o valor procurado?");
            int valorProcurado = int.Parse(Console.ReadLine());

            string retornaBusca = arvore.Buscar(valorProcurado) ? "O valor " + valorProcurado + " foi encontrado na árvore!" : "O valor " + valorProcurado + " não existe na árvore!";
            Console.WriteLine(retornaBusca);
            Console.WriteLine();
            Console.WriteLine("Deseja fazer uma nova consulta?(S - sim / N - nao)");
            char novaConsulta = char.Parse(Console.ReadLine().ToUpper());

            if (novaConsulta == 'S')
            {
                Console.Clear();
                Consultar();
            }

            else
            {
                Console.Clear();
                Menu();
            }

        }
        static void Remover()
        {
            Console.WriteLine("Qual o valor que deseja remover?");
            int valorRemover = int.Parse(Console.ReadLine());
            string retornaRemovido = arvore.Remover(valorRemover) ? "O valor " + valorRemover + " Foi removido com sucesso!" : "O valor " + valorRemover + " nao existe na árvore!";
            Console.WriteLine(retornaRemovido);

            Console.WriteLine("Deseja fazer uma nova exclusão?(S - sim / N - nao)");
            char novaExclusao = char.Parse(Console.ReadLine().ToUpper());

            if (novaExclusao == 'S')
            {
                Console.Clear();
                Remover();

            }

            else
            {
                Console.Clear();
                Menu();
            }

            //arvore.Remover(24); // Nó Folha
            //arvore.Remover(42); // possui filho esquerdo
            //arvore.Remover(69); // possui filho direito
            //arvore.Remover(65); // Possui Filho Direito e Esquerdo
        }
    }
}
