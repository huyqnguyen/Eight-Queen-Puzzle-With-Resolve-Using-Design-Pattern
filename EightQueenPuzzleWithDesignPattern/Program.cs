using EightQueenPuzzleWithDesignPattern.Composite;
using EightQueenPuzzleWithDesignPattern.Interator;
using EightQueenPuzzleWithDesignPattern.Memento;
using System;
using System.Collections.Generic;

namespace EightQueenPuzzleWithDesignPattern
{
    class Program
    {
        public static int NumberOfQueens = 8;

        static void Main(string[] args)
        {
            Collection collection = new Collection();
            for (int i = 0; i < 8; i++)
            {

            }
            if(collection.Count > 0)
            {
                List<Iterator> iteratores = collection.CreateIterator();
                foreach (var iterator in iteratores)
                {
                    ProspectMemory m = new ProspectMemory();
                    for (ChessBoard item = iterator.Current;
                        !iterator.IsDone; item = iterator.Next())
                    {
                        Console.WriteLine(string.Format("Memento  : {0} - {1} - {2}", item.Line, item.Row, item.Parent));
                    }
                }
            }
            

            
            Console.ReadKey();
        }
    }
}
