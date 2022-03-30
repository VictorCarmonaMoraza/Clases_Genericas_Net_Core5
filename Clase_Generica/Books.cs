using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Generica
{
    public class Books<T>
    {
        private T book;
        public T Book
        { 
            get { return book; }
            set { book = value; }
        }

        
    }
}
