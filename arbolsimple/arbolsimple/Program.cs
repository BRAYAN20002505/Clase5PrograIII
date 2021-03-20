using arbolsimple.clases.ArbolBinarioOrdenado;
using arbolsimple.clases.JuegoAnimal;
using System;
using System.Collections;
namespace arbolsimple
{
    class Program
    {

        static void Main(string[] args)
        {
           // juegoAnimales();
           // PruebaOrden();
            ordenanombre();

        }
        public static void preorden(Nodo r)
        {
            if (r != null)
            {
                r.visitar();
                preorden(r.subarbolIzquierdo());
                preorden(r.subarbolDerecho());

            }

        }

        public static void indorden(Nodo r)
        {
            if (r != null)
            {
                indorden(r.subarbolIzquierdo());
                r.visitar();
                indorden(r.subarbolDerecho());
            }
        }

        public static void postorden(Nodo r)
        {
            if (r != null)
            {
                postorden(r.subarbolIzquierdo());
                postorden(r.subarbolDerecho());
                r.visitar();
            }
        }


       //    public static void ()

       //        try
       //        {

        //            ArbolBinario arbol;
     //    Nodo a1, a2, a;
        //    Stack pila = new Stack();
        //    a1 = ArbolBinario.nuevoArbol(null, "Maria", null);
        //            a2 = ArbolBinario.nuevoArbol(null, "Fabrizio", null);
        //            a = ArbolBinario.nuevoArbol(a1, "Gaby", a2);
        //            pila.Push(a);//apilar
        //            a1 = ArbolBinario.nuevoArbol(null, "Andrea", null);
        //            a2 = ArbolBinario.nuevoArbol(null, "Abel", null);
        //            a = ArbolBinario.nuevoArbol(a1, "Monica", a2);
        //            pila.Push(a);//apilar

        //            a1 = (Nodo) pila.Pop();
        //    a2 = (Nodo) pila.Pop();

         //    a = ArbolBinario.nuevoArbol(a1, "Hector", a2);
        //            arbol = new ArbolBinario(a);


        //    Console.WriteLine("preorden");
        //            preorden(a);

        //    Console.WriteLine("postorden");
        //            postorden(a);
        //    Console.WriteLine("inorden");
        //            indorden(a);

        //}
        //        catch (Exception ex)
        //        {
        //            Console.WriteLine("Ups hubo un error!" + ex.Message);
        //        }


        static void juegoAnimales()
        {
            Console.WriteLine("juguemos a adivinar animales");
            Boolean otroJuego = true;
            AdivinaAnimal juego = new AdivinaAnimal();

            do
            {
                juego.jugar();
                Console.WriteLine("jugamos otra vez");
                otroJuego = juego.respuesta();

            } while (otroJuego);
        }


        static void PruebaOrden()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            int[] datos = { 30, 5, 2, 40, 36, 85 };
            SoloNumeros es = new SoloNumeros();

            foreach (int d in datos)
            {
                es.numero = d;
                es.descripcion = $"insertar Np.{d}";
                ArBus.insertar(es);
                es = new SoloNumeros();
            }

            int pausa;
            pausa = 0;
            es = new SoloNumeros();
            es.numero = 36;
            es.descripcion = "cualquier numero";
            ArBus.eliminar(es);
            pausa = 0;



        }

        //metodo nuevo para ordenar el arbol con base a los nombres
        public static void ordenanombre()
        {
            ArbolBinarioBusqueda ArBus = new ArbolBinarioBusqueda();
            string[] nombres = { "gabriel", "daniel", "brayan", "fernando" };
            Estudiante es = new Estudiante();
            foreach (string d in nombres)
            {
                es.nombre = d;
                es.descripcion = $"insertar Nombre.{d}";
                ArBus.insertar(es);//muestra arbol
                es = new Estudiante();
            }

            int pausa;
            pausa = 0;
            es = new Estudiante();

        }


    }

}
