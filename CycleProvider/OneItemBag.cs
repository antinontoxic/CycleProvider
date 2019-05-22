using CycleProvider.Contracts;

namespace CycleProvider
{
    public class OneItemBag<T> where T: class
    {
        private T _item;
        private bool _isEmpty = true;

        public void Put(T item)
        {
            if (!_isEmpty) throw new OneItemBagException(InvalidOperationExceptionMessages.BagIsNotEmpty);

            _item = item;
            _isEmpty = false;
        }

        public T Get()
        {
            if (_isEmpty) throw new OneItemBagException(InvalidOperationExceptionMessages.BagIsEmpty);

            _isEmpty = true;

            var returnValue = _item;
            _item = null;

            return returnValue;

        }
    }
}
