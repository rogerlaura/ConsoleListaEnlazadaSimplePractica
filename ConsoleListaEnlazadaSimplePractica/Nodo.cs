using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleListaEnlazadaSimplePractica
{
    internal class Nodo
    {
        public string nombre;
        public int canthoras;
        //SE AÑADIO EL NOMBRE Y SEXO DEL DOCENTE
        public String nombred;
        public char sexod; //'M'-> Masculino 'F'-> Femenino
        public Nodo siguiente;
        public Nodo()
        {
            this.nombre = "";
            this.canthoras = 0;
            this.nombred = "";
            this.sexod = ' ';
            this.siguiente = null;
        }
    }
}
