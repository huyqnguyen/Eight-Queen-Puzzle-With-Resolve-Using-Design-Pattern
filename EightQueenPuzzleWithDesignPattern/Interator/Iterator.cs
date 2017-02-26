namespace EightQueenPuzzleWithDesignPattern.Interator
{
    public class Iterator : IAbstractIterator
    {
        private ChessBoard _current;

        public Iterator(ChessBoard current)
        {
            this._current = current;
        }

        public ChessBoard Next()
        {
            if (!IsDone)
                return _current.Parent as ChessBoard;
            else
                return null;
        }

        public ChessBoard Current
        {
            get { return _current; }
        }

        public bool IsDone
        {
            get { return _current.Row > 0; }
        }
    }
}
