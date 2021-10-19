using System;

namespace Arvore_Binaria
{
    class Program
    {
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            ArvoreBinaria arvore = new ArvoreBinaria();

            arvore.Inserir(65);
            arvore.Inserir(13);
            arvore.Inserir(84);
            arvore.Inserir(69);
            arvore.Inserir(42);
            arvore.Inserir(1);
            arvore.Inserir(24);
            arvore.Inserir(91);
            arvore.Inserir(73);
            arvore.Inserir(96);


            Console.WriteLine("Valores inseridos na Árvore Binária");

            //for (var i = 0; i < 10; i++) {
            //    var val = rnd.Next(1, 999);
            //    arvore.Inserir(val);
            //}

            //string retornaBusca = arvore.Buscar(42) ? "Valor encontrado!" : "Não existe esse valor na árvore!";
            //Console.WriteLine(retornaBusca);

            //int nivel = arvore.Nivel();
            //string retornaNivel = nivel > -1 ? "Nível: " + nivel : "Não existe uma árvore.";
            //Console.WriteLine(retornaNivel);

            //int altura = arvore.Altura();
            //string retornaAltura = altura > 0 ? "Altura: " + altura : "Não existe uma árvore.";
            //Console.WriteLine(retornaAltura);


            //Console.Write("Pré-Ordem: ");
            //arvore.PreOrdem();

            //Console.Write("\n\nIn-Ordem: ");
            //arvore.InOrdem();

            //Console.Write("\n\nPós-Ordem: ");
            //arvore.PosOrdem();

            //Console.WriteLine(arvore.Buscar(24) ? "Valor encontrado!" : "Não existe esse valor na árvore!");
            //string retornaRemover = arvore.Remover(13) ? "Valor removido com sucesso!" : "Valor não encontrado"; // Nó Folha
            //Console.WriteLine(retornaRemover);
            //Console.WriteLine(arvore.Buscar(24) ? "Valor encontrado!" : "Não existe esse valor na árvore!");

            //arvore.Remover(42); // Possui Filho Esquerdo
            //arvore.Remover(69); // Possui Filho Direito
            //arvore.Remover(65); // Possui Filho Direito e Esquerdo
        }
    }
}
