using System;

namespace Arvore_Binaria
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            Console.WriteLine("Inserindo valores na Árvore Binária: ");

            arvore.Inserir(65);
            arvore.Inserir(13);
            arvore.Inserir(84);
            arvore.Inserir(42);
            arvore.Inserir(69);
            arvore.Inserir(91);
            arvore.Inserir(24);
            arvore.Inserir(96);
            arvore.Inserir(1);
            arvore.Inserir(73);

            //for (var i = 0; i < 10; i++)
            //{
            //    var val = rnd.Next(1, 999);
            //    arvore.Inserir(val);
            //}

            string retornaBusca = arvore.Buscar(42) ? "Valor encontrado!": "Não existe esse valor na árvore!";
            Console.WriteLine(retornaBusca);

            //string retornaBuscaRecursiva = arvore.BuscarRecursivo(42) ? "Valor encontrado!" : "Não existe esse valor na árvore!";
            //Console.WriteLine(retornaBuscaRecursiva);

            //arvore.Remover(24); // Nó Folha
            //arvore.Remover(42); // Possui Filho Esquerdo
            arvore.Remover(69); // Possui Filho Direito
            arvore.Remover(65); // Possui Filho Direito e Esquerdo
        }
    }
}
