using System;
using System.Collections.Generic;

namespace EightQueenPuzzleWithDesignPattern.Composite
{
    public class CompositeElement : ChessBoard
    {
        private List<ChessBoard> elements =  new List<ChessBoard>();

        public CompositeElement(int x, int y, bool state) : base(x, y, state)
        {
        }

        public override void Add(ChessBoard d)
        {
            elements.Add(d);
        }

        public override void Display(int indent)
        {
            Console.WriteLine(new String('-', indent) + "+ " + X + " " + Y);

            // Display each child element on this node
            foreach (ChessBoard d in elements)
            {
                d.Display(indent + 2);
            }
        }

        public override void Remove(ChessBoard d)
        {
            elements.Remove(d);
        }

        public override void RestoreMemento(Memento.Memento memento)
        {
            this.X = memento.X;
            this.Y = memento.Y;
            this.State = memento.State;
        }

        public override Memento.Memento SaveMemento()
        {
            return new Memento.Memento(_x, _y, _state);
        }
    }
}
