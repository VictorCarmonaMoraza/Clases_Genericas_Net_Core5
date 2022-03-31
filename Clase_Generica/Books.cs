using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_Generica
{
    public class Books<T> where T : Book
    {
        private T book;
        public T Book
        { 
            get { return book; }
            set { book = value; }
        }

        
    }
}
