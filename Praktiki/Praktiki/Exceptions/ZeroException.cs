using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Exceptions
{
    public class ZeroException : Exception
    {
        public ZeroException() : this ("Cannot be less than zero")
        {

        }
        public ZeroException(string msj) : base (msj) 
        {
            
        }

    }
}
