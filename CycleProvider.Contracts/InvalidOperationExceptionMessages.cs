using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CycleProvider.Contracts
{
    public static class InvalidOperationExceptionMessages
    {
        public static readonly string EmptyCycleProvider = "Cycle Provider has no items";
        public static readonly string BagIsNotEmpty = "Invalid Operation. Bag is not empty";
        public static readonly string BagIsEmpty = "Invalid Operation. Bag is empty";
    }
}
