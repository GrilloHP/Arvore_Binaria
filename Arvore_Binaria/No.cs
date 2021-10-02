using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore_Binaria
{
    class No
    {
        public int Valor { get; }

        public No NoEsquerdo { get; set; }

        public No NoDireito { get; set; }

        /// <summary>
        /// Cria uma instância do Nó com os argumentos utilizados.
        /// </summary>
        /// <param name="valor">Representa o valor a ser atribuido ao nó.</param>
        public No(int valor)
        {
            Valor = valor;
        }

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

        
    }
}
