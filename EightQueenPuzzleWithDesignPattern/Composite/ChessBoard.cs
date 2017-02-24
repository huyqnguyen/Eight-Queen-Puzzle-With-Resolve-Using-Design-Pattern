namespace EightQueenPuzzleWithDesignPattern
{
    public abstract class ChessBoard
    {
        protected int _x;
        protected int _y;
        protected bool _state;
        // Constructor
        public ChessBoard(int x, int y, bool state)
        {
            this._x = x;
            this._y = y;
            this._state = state;
        }


        public int X
        {
            get { return _x; }
            set { _x = value; }
        }

        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }

        public bool State
        {
            get { return _state; }
            set { _state = value; }
        }

        public abstract void Add(ChessBoard d);
        public abstract void Remove(ChessBoard d);
        public abstract void Display(int indent);
        public abstract Memento.Memento SaveMemento();
        public abstract void RestoreMemento(Memento.Memento memento);
    }
}
