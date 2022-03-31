using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Generica
{
    public class Books<T> where T : Book
    {
        private Nodo<T> primero;

        public void Add(T obj)
        {
            var nuevo = new Nodo<T>(obj);
            Nodo<T> valor;
            if (primero == null)
            {
                primero = nuevo;
            }
            else
            {
                valor = primero;
                while (valor!=null)
                {
                    valor.next = primero;
                    primero = nuevo;
                    break;
                }
            }
        }

        //private T book;
        //public T Book
        //{ 
        //    get { return book; }
        //    set { book = value; }
        //}


    }
}
