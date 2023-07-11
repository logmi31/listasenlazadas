using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Listasenlazadas
{
    public class Lista
    {

        public Nodo inicio;

        public Lista() {
            inicio = null;
        }

        public void InsertarF(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                }
                puntero.siguiente = auxiliar;
            }
        }


        public void InsertarI(int item)
        {
            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;

            if (inicio == null)
            {
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                inicio = auxiliar;
                auxiliar.siguiente = puntero;
            }
        }


        public void EliminarI() {

            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia!");
            }
            else
            {
                inicio = inicio.siguiente;
            }

        }

        public void EliminarF() {

            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia!");
            }
            else
            {
                Nodo punteroAnt, punteroPost;
                punteroAnt = inicio;
                punteroPost = inicio;

                while (punteroPost.siguiente != null)
                {
                    punteroAnt = punteroPost;
                    punteroPost = punteroPost.siguiente;
                }
                punteroAnt.siguiente = null;
            }

        }

        public void InsertarP(int item, int pos) {

            Nodo auxiliar = new Nodo();
            auxiliar.dato = item;
            auxiliar.siguiente = null;
            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia!, se inserta en la primer aposicion");
                inicio = auxiliar;
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                if (pos == 1)
                {
                    inicio = auxiliar;
                    auxiliar.siguiente = puntero;
                }
                else
                {
                    for (int i = 1; i < pos - 1; i++)
                    {
                        puntero = puntero.siguiente;
                        if (puntero.siguiente == null)
                            break;
                    }
                    Nodo punteroNext;
                    punteroNext = puntero.siguiente;
                    puntero.siguiente = auxiliar;
                    auxiliar.siguiente = punteroNext;
                }
            }

        }

        public void mostrar() {

            if (inicio == null)
            {
                Console.WriteLine("La lista esta vacia");
            }
            else
            {
                Nodo puntero;
                puntero = inicio;
                Console.Write("{0}-->\t", puntero.dato);
                while (puntero.siguiente != null)
                {
                    puntero = puntero.siguiente;
                    Console.Write("{0}-->\t", puntero.dato);
                }
                Console.WriteLine();
            }

        }
    }
}
