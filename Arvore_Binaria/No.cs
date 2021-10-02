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

        #region Inserir um novo nó

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

        #region Buscar um nó

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

        // Falta Documentar
        #region Altura
        public int Altura()
        {
            if (this.NoEsquerdo == null && this.NoDireito == null)
                return 1;

            int esquerda = 0;
            int direita = 0;

            if (this.NoEsquerdo != null)
                esquerda = this.NoEsquerdo.Altura();
            if (this.NoDireito != null)
                direita = this.NoDireito.Altura();

            if (esquerda > direita)
                return esquerda + 1;
            else
                return direita + 1;
        }
        #endregion

        // Falta Documentar
        #region Nível
        public int Nivel()
        {
            if (this.NoEsquerdo == null && this.NoDireito == null)
                return 0;

            int esquerda = -1;
            int direita = -1;

            if (this.NoEsquerdo != null)
                esquerda = this.NoEsquerdo.Nivel();
            if (this.NoDireito != null)
                direita = this.NoDireito.Nivel();

            if (esquerda > direita)
                return esquerda + 1;
            else
                return direita + 1;
        }
        #endregion

        // Falta Documentar
        #region Pre Ordem
        public void PreOrdem()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append($"{Valor} ");

            if (NoEsquerdo != null)
                NoEsquerdo.PreOrdem();
            if (NoDireito != null)
                NoDireito.PreOrdem();

            return sb;
        }
        #endregion
    }
}
