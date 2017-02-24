using EightQueenPuzzleWithDesignPattern.Composite;

namespace EightQueenPuzzleWithDesignPattern.Interator
{
    class Iterator : IAbstractIterator
    {
        private Collection _collection;
        private int _current = 0;
        private int _step = 1;

        // Constructor
        public Iterator(Collection collection)
        {
            this._collection = collection;
        }

        // Gets first item
        public CompositeElement First()
        {
            _current = 0;
            return _collection[_current] as CompositeElement;
        }

        // Gets next item
        public CompositeElement Next()
        {
            _current += _step;
            if (!IsDone)
                return _collection[_current] as CompositeElement;
            else
                return null;
        }

        // Gets or sets stepsize
        public int Step
        {
            get { return _step; }
            set { _step = value; }
        }

        // Gets current iterator item
        public CompositeElement CurrentItem
        {
            get { return _collection[_current] as CompositeElement; }
        }

        // Gets whether iteration is complete
        public bool IsDone
        {
            get { return _current >= _collection.Count; }
        }
    }
}
