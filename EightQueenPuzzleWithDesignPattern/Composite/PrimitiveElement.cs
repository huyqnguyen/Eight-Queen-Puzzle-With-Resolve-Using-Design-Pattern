using System;
using EightQueenPuzzleWithDesignPattern.Memento;

namespace EightQueenPuzzleWithDesignPattern.Composite
{
    public class PrimitiveElement : ChessBoard
    {
        public PrimitiveElement(int x, int y, bool state) : base(x, y,state)
        {
        }

        public override void Add(ChessBoard c)
        {
            Console.WriteLine(
              "Cannot add to a PrimitiveElement");
        }

        public override void Remove(ChessBoard c)
        {
            Console.WriteLine(
              "Cannot remove from a PrimitiveElement");
        }

        public override void Display(int indent)
        {
            Console.WriteLine(
              new String('-', indent) + " " + X + " " + Y);
        }

        public override Memento.Memento SaveMemento()
        {
            throw new NotImplementedException();
        }

        public override void RestoreMemento(Memento.Memento memento)
        {
            throw new NotImplementedException();
        }
    }
}
