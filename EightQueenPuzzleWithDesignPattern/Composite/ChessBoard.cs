namespace EightQueenPuzzleWithDesignPattern
{
    public abstract class ChessBoard
    {
        protected int _x;
        protected int _y;
        protected bool _state;
        // Constructor
        public ChessBoard(int x, int y)
        {
            this._x = x;
            this._y = y;
            this._state = false;
        }


        public int X
        {
            get { return _x; }
        }

        public int Y
        {
            get { return _y; }
        }

        public bool State
        {
            get { return _state; }
        }

        public abstract void Add(ChessBoard d);
        public abstract void Remove(ChessBoard d);
        public abstract void Display(int indent);
    }
}
