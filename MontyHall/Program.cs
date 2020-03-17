using System;

namespace MontyHall {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");
            var mh = new MontyHallGame(2, new RandomDoorSelector());
            Console.WriteLine(mh.hasWon());
        }
    }
}