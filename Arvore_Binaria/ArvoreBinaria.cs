﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore_Binaria
{
    class ArvoreBinaria
    {
        #region Atirbutos
        public No Raiz { get; set; }
        #endregion

        #region Inserir

        /// <summary>
        /// Insere um valor na árvore binária.
        /// </summary>
        /// <param name="valor">Representa o valor a ser inserido no nó.</param>
        public void Inserir(int valor)
        {
            if (Raiz != null)
                Raiz.Inserir(valor);
            else
                Raiz = new No(valor);
        }
        #endregion

        #region Buscar

        /// <summary>
        /// Realiza a busca de um elemento dentro da árvore binária utilizando o método de recursividade.
        /// </summary>
        /// <param name="valor">Representa o valor a ser buscado na árvore.</param>
        /// <returns></returns>
        public bool Buscar(int valor)
        {
            if (Raiz != null)
                return Raiz.Buscar(valor);
            else
                return false;
        }
        #endregion

        #region Buscar por recursividade
        public bool BuscarRecursivo(int valor)
        {
            if (Raiz != null)
                return Raiz.Buscar(valor);
            else
                return false;
        }
        #endregion

        #region Remover

        /// <summary>
        /// Remove um valor da árvore binária.
        /// </summary>
        /// <param name="valor">Representa o valor a ser removido da árvore.</param>
        /// <returns></returns>
        public bool Remover(int valor)
        {
            No atual = Raiz;
            No pai = Raiz;
            bool filhoEsquerdo = false;

            if (atual == null)
                return false;

            while (atual != null && atual.Valor != valor)
            {
                pai = atual;

                if (valor < atual.Valor)
                {
                    atual = atual.NoEsquerdo;
                    filhoEsquerdo = true;
                }
                else
                {
                    atual = atual.NoDireito;
                    filhoEsquerdo = false;
                }
            }

            if (atual == null)
                return false;
            
            if (atual.NoDireito == null && atual.NoEsquerdo == null)
            {
                if (atual == Raiz)
                    Raiz = null;
                else
                {
                    if (filhoEsquerdo)
                        pai.NoEsquerdo = null;
                    else
                        pai.NoDireito = null;
                }
                return true;
            }
                
                
            else if (atual.NoDireito == null)
            {
                if (atual == Raiz)
                    Raiz = atual.NoEsquerdo;
                else
                {
                    if (filhoEsquerdo)
                        pai.NoEsquerdo = atual.NoEsquerdo;
                    else
                        pai.NoDireito = atual.NoEsquerdo;
                }
                return true;
            }
               
            else if (atual.NoEsquerdo == null)
            {
                if (atual == Raiz)
                    Raiz = atual.NoDireito;
                else
                {
                    if (filhoEsquerdo)
                        pai.NoEsquerdo = atual.NoDireito;
                    else
                        pai.NoDireito = atual.NoDireito;
                }
                return true;
            }
                
            else
            {
                No sucessor = EncontrarSucessor(atual);

                if (atual == Raiz)
                    Raiz = sucessor;
                else if (filhoEsquerdo)
                    pai.NoEsquerdo = sucessor;
                else
                    pai.NoDireito = sucessor;
                return true;
            }
        }


        /// <summary>
        /// Encontra o sucessor quando deseja-se remover um nó com dois filhos. 
        /// </summary>
        /// <param name="no">Representa o nó a ser removido.</param>
        /// <returns></returns>
        public No EncontrarSucessor(No no)
        {
            No paiDoSucessor = no;
            No sucessor = no;
            No atual = no.NoDireito;

            while (atual != null)
            {
                paiDoSucessor = sucessor;
                sucessor = atual;
                atual = atual.NoEsquerdo;
            }

            if (sucessor != no.NoDireito)
            {
                paiDoSucessor.NoEsquerdo = sucessor.NoDireito;
                sucessor.NoDireito = no.NoDireito;
            }
            sucessor.NoEsquerdo = no.NoEsquerdo;


            return sucessor;
        }
        #endregion
    }
}
