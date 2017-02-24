using EightQueenPuzzleWithDesignPattern.Composite;

namespace EightQueenPuzzleWithDesignPattern.Interator
{
    interface IAbstractIterator
    {
        CompositeElement First();
        CompositeElement Next();
        bool IsDone { get; }
        CompositeElement CurrentItem { get; }
    }
}
