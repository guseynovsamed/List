using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Models
{
    public class Bird : Animal
    {
        public Bird()
        {
            Console.WriteLine("Bird ctor");
        }
        public string Color { get; set; }
    }
}
