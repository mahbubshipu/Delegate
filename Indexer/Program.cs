using System;

namespace Indexer
{
    class Program
    {
        static void Main(string[] args)
        {
            KeyBoard keyBoard = new KeyBoard();
            var key=keyBoard[95];
            keyBoard['A'] = new Key { };
            Console.WriteLine(key);
        }
    }
}
