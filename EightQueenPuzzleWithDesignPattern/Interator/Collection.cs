using System.Collections;
using System.Collections.Generic;

namespace EightQueenPuzzleWithDesignPattern.Interator
{
    public class Collection : IAbstractCollection
    {
        private ArrayList _items = new ArrayList();

        public List<Iterator> CreateIterator()
        {
            List<Iterator> list = new List<Iterator>();
            foreach(ChessBoard item in _items)
            {
                list.Add(new Iterator(item));
            }
            return list;
        }

        // Gets item count
        public int Count
        {
            get { return _items.Count; }
        }

        // Indexer
        public object this[int index]
        {
            get { return _items[index]; }
            set { _items.Add(value); }
        }
    }

}
