using System;
using System.Collections.Generic;
using System.Text;

namespace arbolsimple.clases.ArbolBinarioOrdenado
{
    class Estudiante : Comparador
    {

        public int numMat;
        public string nombre;
        public string descripcion;

        public bool igualQue(object q)
        {
            throw new NotImplementedException();
        }


        //lo que se modifico a la clase fue el return de todos los metodos, usando CompareTo 
        //para obtener un binario que nos indique cual es mayor, en base a eso redirigirlo a la
        //derecha o izquierda
        public bool mayorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;

            return nombre.CompareTo(p2.nombre) >= 0;
        }

        public bool menorIgualQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) <= 0;
        }

        public bool menorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) < 0;
        }

        public bool mayorQue(object q)
        {
            Estudiante p2 = (Estudiante)q;
            return nombre.CompareTo(p2.nombre) > 0;

           

        }
    }
}
