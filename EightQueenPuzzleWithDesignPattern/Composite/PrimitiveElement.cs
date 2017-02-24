using System;

namespace EightQueenPuzzleWithDesignPattern.Composite
{
    class PrimitiveElement : ChessBoard
    {
        public PrimitiveElement(int x, int y) : base(x, y)
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
    }
}
