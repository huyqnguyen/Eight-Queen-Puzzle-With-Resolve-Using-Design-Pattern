using EightQueenPuzzleWithDesignPattern.Composite;
using EightQueenPuzzleWithDesignPattern.Interator;
using System;

namespace EightQueenPuzzleWithDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new CompositeElement(0,0);
            collection[1] = new CompositeElement(0,1);
            collection[2] = new CompositeElement(0,2);
            collection[3] = new CompositeElement(0,3);
            collection[4] = new CompositeElement(0,4);
            collection[5] = new CompositeElement(0,5);
            collection[6] = new CompositeElement(0,6);
            collection[7] = new CompositeElement(0,7);
            collection[8] = new CompositeElement(0,8);

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 1;

            for (CompositeElement item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(string.Format("{0} - {1}",item.X, item.Y));
            }

            // Wait for user
            Console.ReadKey();
        }
    }
}
