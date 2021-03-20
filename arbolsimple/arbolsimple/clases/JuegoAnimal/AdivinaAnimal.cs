
using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple.clases.JuegoAnimal
{
    class AdivinaAnimal
    {

        private static Nodo raiz;


        public AdivinaAnimal()
        {
            raiz = new Nodo("Elefante");
    }

        public void jugar()
        {
            var nodo = raiz;

            while(nodo!= null)// iteracion del arbol
            {
                if (nodo.izquierda != null) //existe una pregunta
                {
                    Console.WriteLine(nodo.valorNodo());
                    nodo = (respuesta()) ? nodo.izquierda : nodo.derecha;

                 
                }
                else
                {
                    Console.WriteLine($"YA SE , ES UN {nodo.valorNodo()}?");
                    if (respuesta())
                    {
                        Console.WriteLine("Gane!!!!!!!!!!");

                       
                        nodo = null;
                        return;
                    }
                    else
                    {
                        animalNuevo(nodo);
                    }

                    nodo = null;
                    return;
                }
            }
        }

        public bool respuesta()
        {
            while (true)
            {
                String resp = Console.ReadLine().ToLower().Trim();

                if (resp.Equals("si")) return true;
                if (resp.Equals("no")) return false;
                Console.WriteLine("La respuesta debe ser si o  no ");
            }
        }


        private void animalNuevo(Nodo nodo)
        {

            String animalNodo = (String)nodo.valorNodo();
            Console.WriteLine("cual es tu animal pues?");
            String nuevoA = Console.ReadLine();
            Console.WriteLine($"que preg con resp si/ no puedo acer para decir que es un {nuevoA}");
            string pregunta = Console.ReadLine();
            Nodo nodo1 = new Nodo(animalNodo);
            Nodo nodo2 = new Nodo(nuevoA);
            Console.WriteLine($"para un(a) {nuevoA} la respuesta si  / no? ");
            nodo.nuevoValor(pregunta + "?");

            if (respuesta())
            {
                nodo.izquierda = nodo2;
                nodo.derecha = nodo1;
            }
            else
            {
                nodo.izquierda = nodo1;
                nodo.derecha = nodo2;

            }
        }
    }
   

}
    


