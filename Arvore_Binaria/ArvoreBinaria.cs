using System;
using System.Collections.Generic;
using System.Text;

namespace Arvore_Binaria
{
    class ArvoreBinaria
    {
        public No Raiz { get; set; }

        public void Inserir(int valor)
        {
            if (Raiz != null)
                Raiz.Inserir(valor);
            else
                Raiz = new No(valor);
        }

        public bool Buscar(int valor)
        {
            if (Raiz != null)
                return Raiz.Buscar(valor);
            else
                return false;
        }

        public bool BuscarRecursivo(int valor)
        {
            if (Raiz != null)
                return Raiz.BuscarRecursivo(valor);
            else
                return false;
        }

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

            //Nó Folha
            if (atual.NoDireito == null && atual.NoEsquerdo == null)
                if (atual == Raiz)
                    Raiz = null;
                else
                {
                    if (filhoEsquerdo)
                        pai.NoEsquerdo = null;
                    else
                        pai.NoDireito = null;
                }
            else if (atual.NoDireito == null)
                if (atual == Raiz)
                    Raiz = atual.NoEsquerdo;
                else
                {
                    if (filhoEsquerdo)
                        pai.NoEsquerdo = atual.NoEsquerdo;
                    else
                        pai.NoDireito = atual.NoEsquerdo;
                }
            else if (atual.NoEsquerdo == null)
                if (atual == Raiz)
                    Raiz = atual.NoDireito;
                else
                {
                    if (filhoEsquerdo)
                        pai.NoEsquerdo = atual.NoDireito;
                    else
                        pai.NoDireito = atual.NoDireito;
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
            }
            return false;
        }

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

    }
}
