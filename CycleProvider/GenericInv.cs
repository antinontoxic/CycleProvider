using CycleProvider.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider
{
    public class GenericInv<T> : IGenericInvOut<T>
    {
        private T _item;

        public void Put(T item)
        {
            item = _item;
        }

        public T Get()
        {
            return _item;
        }
    }
}
