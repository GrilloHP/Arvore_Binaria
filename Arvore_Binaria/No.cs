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

        public No(int valor)
        {
            Valor = valor;
        }

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

        public bool Buscar(int valor)
        {
            No noAtual = this;

            while (noAtual != null)
            {
                if (valor == noAtual.Valor)
                {
                    return true;
                }
                else if (valor > noAtual.Valor)
                    noAtual = noAtual.NoDireito;
                else
                    noAtual = noAtual.NoEsquerdo;
            }
            return false;
        }

        public bool BuscarRecursivo(int valor)
        {
            if (valor == Valor)
                return true;
            else if (valor < Valor && NoEsquerdo != null)
                return NoEsquerdo.BuscarRecursivo(valor);
            else if (NoDireito != null)
                return NoDireito.BuscarRecursivo(valor);
            else
                return false;
        }
    }
}
