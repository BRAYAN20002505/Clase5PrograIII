using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple.clases.ArbolBinarioOrdenado
{
    class ArbolBinarioBusqueda : ArbolBinario
    {
        public ArbolBinarioBusqueda() : base()
        {


        }


        public Nodo buscar(object buscando)
        {
            Comparador dato;
            dato = (Comparador)buscando;
            if(raiz == null)
            {
                return null;
            }else
            {
                return localizar(raizArbil(), dato);
            }

        }

        protected Nodo localizar(Nodo raizSub, Comparador buscando)
        {
            if (raizSub == null)
            {
                return null;

            }
            else if (buscando.igualQue(raizSub.valorNodo()))
            {
                return raiz;
            }
            else if (buscando.menorQue(raizSub.valorNodo())) 
            {
                return localizar(raizSub.subarbolIzquierdo(), buscando);
            }
            else
            {
                return localizar(raizSub.subarbolDerecho(), buscando);
            }

        }
        
        
        public void insertar (object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = insertar(raiz, dato);

        } 

        protected  Nodo insertar (Nodo raizSub, Comparador dato)
        {
            if(raizSub == null)
            {
                raizSub = new Nodo(dato);

            }else if (dato.menorIgualQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = insertar(raizSub.subarbolIzquierdo(), dato);
                raizSub.ramaIzquierda(iz);

            }else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = insertar(raizSub.subarbolDerecho(), dato);
                raizSub.ramaDerecha(dr);

            }
            return raizSub;

        }//ef



        public void eliminar(object valor)
        {
            Comparador dato;
            dato = (Comparador)valor;
            raiz = eliminar(raiz, dato);
        }

        protected Nodo eliminar(Nodo raizSub, Comparador dato)
        {
            if (raizSub == null)
            {
                throw new Exception("NO HAY NODO PARA ELIMINAR");
            }else if (dato.menorQue(raizSub.valorNodo()))
            {
                Nodo iz;
                iz = eliminar(raizSub.subarbolIzquierdo(), dato);
                raizSub.ramaIzquierda(iz);
            }else if (dato.mayorQue(raizSub.valorNodo()))
            {
                Nodo dr;
                dr = eliminar(raizSub.subarbolDerecho(), dato);
                raizSub.ramaDerecha(dr);
            }
            else//nodo encontrado
            {
                Nodo q;
                q = raizSub; //este es eo nodo que se quita del arbol
                if (q.subarbolIzquierdo() == null)
                {
                    raizSub = q.subarbolDerecho();

                }else if (q.subarbolDerecho() == null)
                {
                    raizSub = q.subarbolIzquierdo();
                }else //tiene rama izquierda y derecha
                {
                    q=reemplazar(q);

                }
                q = null;
            }
            return raizSub;
        }


        private Nodo reemplazar(Nodo act)
        {
            Nodo a, p;
            p = act;
            a = act.subarbolIzquierdo(); // rama de nodos menores
            while (a.subarbolDerecho() != null)
            {
                p = a;
                a = a.subarbolDerecho();
            }
            act.nuevoValor(a.valorNodo());
            if (p == act)
            {
                p.ramaIzquierda(a.subarbolIzquierdo());
            }
            else
            {
                p.ramaDerecha(a.subarbolIzquierdo());
            }
            return a;
        }

    }
}//fin clase


