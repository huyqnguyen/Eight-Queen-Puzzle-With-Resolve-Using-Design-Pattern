using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EightQueenPuzzleWithDesignPattern.Composite
{
    class CompositeElement : ChessBoard
    {
        private List<ChessBoard> elements =  new List<ChessBoard>();

        public CompositeElement(int x, int y) : base(x, y)
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
    }
}
