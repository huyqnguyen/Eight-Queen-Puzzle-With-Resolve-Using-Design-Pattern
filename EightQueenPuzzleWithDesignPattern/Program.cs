using EightQueenPuzzleWithDesignPattern.Composite;
using EightQueenPuzzleWithDesignPattern.Interator;
using EightQueenPuzzleWithDesignPattern.Memento;
using System;

namespace EightQueenPuzzleWithDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Collection collection = new Collection();
            collection[0] = new CompositeElement(0, 0, false);
            collection[1] = new CompositeElement(0, 1, false);
            collection[2] = new CompositeElement(0, 2, false);
            collection[3] = new CompositeElement(0, 3, false);
            collection[4] = new CompositeElement(0, 4, false);
            collection[5] = new CompositeElement(0, 5, false);
            collection[6] = new CompositeElement(0, 6, false);
            collection[7] = new CompositeElement(0, 7, false);
            collection[8] = new CompositeElement(0, 8, false);

            // Create iterator
            Iterator iterator = collection.CreateIterator();

            // Skip every other item
            iterator.Step = 1;
            ProspectMemory m = new ProspectMemory();
            for (CompositeElement item = iterator.First();
                !iterator.IsDone; item = iterator.Next())
            {
                m.Memento = item.SaveMemento();
                
                item.X += item.X;
                item.Y += item.Y;
                item.State = !item.State;
                Console.WriteLine(string.Format("Modified : {0} - {1} - {2}", item.X, item.Y, item.State));
                item.RestoreMemento(m.Memento);
                Console.WriteLine(string.Format("Memento  : {0} - {1} - {2}", item.X, item.Y, item.State));
            }
            // Wait for user
            Console.ReadKey();
        }
    }
}
