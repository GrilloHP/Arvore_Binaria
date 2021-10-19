using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore_Binaria
{
    class No
    {
        #region Atributos
        public int Valor { get; }

        public No NoEsquerdo { get; set; }

        public No NoDireito { get; set; }
        #endregion

        #region Contrutores

        /// <summary>
        /// Cria uma instância do Nó com os argumentos utilizados.
        /// </summary>
        /// <param name="valor">Representa o valor a ser atribuido ao nó.</param>
        public No(int valor)
        {
            Valor = valor;
        }
        #endregion

        #region Inserir um valor ao nó

        /// <summary>
        /// Insere um valor ao nó.
        /// </summary>
        /// <param name="valor">Representa o valor a ser atribuido ao nó.</param>
        public void Inserir(int valor)
        {
            if (valor >= Valor)
                if (NoDireito == null)
                    NoDireito = new No(valor);
                else
                    NoDireito.Inserir(valor);
            else
            {
                if (NoEsquerdo == null)
                    NoEsquerdo = new No(valor);
                else
                    NoEsquerdo.Inserir(valor);
            }
        }
        #endregion

        #region Buscar um valor

        /// <summary>
        /// Busca um valor entre os nós.
        /// </summary>
        /// <param name="valor">Representa o valor a ser buscado no nó.</param>
        /// <returns></returns>
        public bool Buscar(int valor)
        {
            if (valor == Valor)
                return true;
            else if (valor < Valor && NoEsquerdo != null)
                return NoEsquerdo.Buscar(valor);
            else if (NoDireito != null)
                return NoDireito.Buscar(valor);
            else
                return false;
        }
        #endregion

        #region Altura
        /// <summary>
        /// Percorre a árvore para determinar a altura.
        /// </summary>
        /// <returns>Retorna um inteiro com o valor da altura da árvore.</returns>
        public int Altura()
        {
            if (NoEsquerdo == null && NoDireito == null)
                return 1;

            int esquerda = 0;
            int direita = 0;

            if (NoEsquerdo != null)
                esquerda = NoEsquerdo.Altura();
            if (NoDireito != null)
                direita = NoDireito.Altura();

            if (esquerda > direita)
                return esquerda + 1;
            else
                return direita + 1;
        }
        #endregion

        #region Nível
        /// <summary>
        /// Percorre a árvore para determinar o nível.
        /// </summary>
        /// <returns>Retorna um inteiro com o valor do nível da árvore.</returns>
        public int Nivel()
        {
            if (NoEsquerdo == null && NoDireito == null)
                return 0;

            int esquerda = -1;
            int direita = -1;

            if (NoEsquerdo != null)
                esquerda = NoEsquerdo.Nivel();
            if (NoDireito != null)
                direita = NoDireito.Nivel();

            if (esquerda > direita)
                return esquerda + 1;
            else
                return direita + 1;
        }
        #endregion

        #region Pré Ordem
        /// <summary>
        /// Determina o percurso de varredura pré-ordem da árvore.
        /// </summary>
        public void PreOrdem()
        {
            Console.Write($"{Valor} "); 
            
            if (NoEsquerdo != null)
                NoEsquerdo.PreOrdem();
            if (NoDireito != null)
                NoDireito.PreOrdem();
        }
        #endregion

        #region In Ordem
        /// <summary>
        /// Determina o percurso de varredura in-ordem da árvore.
        /// </summary>
        public void InOrdem()
        {
            if (NoEsquerdo != null)
                NoEsquerdo.InOrdem();

            Console.Write($"{Valor} ");

            if (NoDireito != null)
                NoDireito.InOrdem();
        }
        #endregion

        #region Pós Ordem
        /// <summary>
        /// Determina o percurso de varredura pós-ordem da árvore.
        /// </summary>
        public void PosOrdem()
        {
            if (NoEsquerdo != null)
                NoEsquerdo.PosOrdem();

            if (NoDireito != null)
                NoDireito.PosOrdem();

            Console.Write($"{Valor} ");
        }
        #endregion
    }
}
