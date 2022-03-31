using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Generica
{
    public class Nodo<T>
    {
        public T obj;
        public Nodo<T> next;

        public Nodo(T obj)
        {
            this.obj = obj;
            next = null; 
        }

    }
}
