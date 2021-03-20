using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple
{
    class ArbolBinario
    {
        protected Nodo raiz;

        //Ya que estamos creando el arbol desde 0
        public ArbolBinario()
        {
            raiz = null;
        }

        public ArbolBinario(Nodo raiz)
        {
            this.raiz = raiz;
        }

        public Nodo raizArbil()
        {
            return raiz;
        }

        bool esVacio()
        {
            return raiz == null;
        }

        public static Nodo nuevoArbol(Nodo ramaIzzda, object dato, Nodo ramaDrcha)
        {
            return new Nodo(ramaIzzda, ramaDrcha, dato);
        }

    }
}
