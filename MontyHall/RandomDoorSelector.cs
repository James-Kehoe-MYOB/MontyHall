using System;

namespace MontyHall {
    public class RandomDoorSelector : PrizeDoorSelector {
        Random random = new Random();
        public int GetPrizeDoorNumber() {
            return random.Next(1, 4);
        }
    }
}