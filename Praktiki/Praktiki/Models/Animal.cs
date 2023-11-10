using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki.Models
{
    public class Animal
    {
        public  string Name { get; set; }
        public int Id { get; set; }

        public virtual  void Sound()
        {
            Console.WriteLine("Animal Sound");
        }

        public Animal()
        {
            Console.WriteLine("Animal ctor");
        }
    }
}
