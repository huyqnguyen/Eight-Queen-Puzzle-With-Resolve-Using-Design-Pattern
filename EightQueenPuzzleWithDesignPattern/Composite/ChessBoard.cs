namespace EightQueenPuzzleWithDesignPattern
{
    public abstract class ChessBoard
    {
        protected int _line;
        protected int _row;
        protected ChessBoard _parent;
        // Constructor
        public ChessBoard(int x, int y, ChessBoard parent)
        {
            this._line = x;
            this._row = y;
            this._parent = parent;
        }


        public int Line
        {
            get { return _line; }
            set { _line = value; }
        }

        public int Row
        {
            get { return _row; }
            set { _row = value; }
        }

        public ChessBoard Parent
        {
            get { return _parent; }
            set { _parent = value; }
        }

        public abstract void Add(ChessBoard d);
        public abstract void Remove(ChessBoard d);
        public abstract Memento.Memento SaveMemento();
        public abstract void RestoreMemento(Memento.Memento memento);
        public abstract ChessBoard GetNextMove();
    }
}
