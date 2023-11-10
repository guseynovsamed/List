using Praktiki.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praktiki
{
    public class Generic<T> where T : BaseEntity
    {
        private T[] _data;

        public Generic()
        {
            _data = new T[0];
        }


        public void Add(T item)
        {
            Array.Resize(ref _data, _data.Length + 1);
            _data[_data.Length - 1] = item;
        }

        public T[] ShowAll()
        {
            return _data;
        }

        public T GetByID(int id)
        {
            return _data.FirstOrDefault(n => n.Id == id);
        }

        public void DeleteById(int id)
        {
             _data =_data.Where(n=>n.Id != id).ToArray();

        }

    }
} 
