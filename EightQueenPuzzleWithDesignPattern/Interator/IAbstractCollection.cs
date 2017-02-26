using System.Collections.Generic;

namespace EightQueenPuzzleWithDesignPattern.Interator
{
    interface IAbstractCollection
    {
        List<Iterator> CreateIterator();
    }
}
