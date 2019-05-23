using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider.Contracts
{
    [Serializable]
    public class HrException : Exception
    {
        public HrException() { }
        public HrException(string message) : base(message) { }
        public HrException(string message, Exception inner) : base(message, inner) { }
        protected HrException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
