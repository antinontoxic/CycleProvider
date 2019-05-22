using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider.Contracts
{

    [Serializable]
    public class OneItemBagException : Exception
    {
        public OneItemBagException() { }
        public OneItemBagException(string message) : base(message) { }
        public OneItemBagException(string message, Exception inner) : base(message, inner) { }
        protected OneItemBagException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
