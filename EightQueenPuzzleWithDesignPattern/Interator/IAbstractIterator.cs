namespace EightQueenPuzzleWithDesignPattern.Interator
{
    interface IAbstractIterator
    {
        ChessBoard Next();
        bool IsDone { get; }
    }
}
