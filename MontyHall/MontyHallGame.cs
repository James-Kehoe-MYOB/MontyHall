using System;
using System.Collections.Generic;

namespace MontyHall {
    public interface IMontyHallGame {
        bool hasWon();
        void ChangeDoor();
    }

    public class MontyHallGame : IMontyHallGame {
        private bool win;
        private int prize;
        public int choice;
        public int opendoor;
        List<int> choices = new List<int>{1, 2, 3};
        public MontyHallGame(int choice, PrizeDoorSelector selector) {
            prize = selector.GetPrizeDoorNumber();
            this.choice = choice;
            opendoor = SetOpenDoor();
            
            if (choice == prize) {
                win = true;
            }
            else {
                win = false;
            }
        }

        public bool hasWon() {
            return win;
        }

        public void ChangeDoor() {
            List<int> remainingDoors = new List<int>{1, 2, 3};
            remainingDoors.Remove(choice);
            remainingDoors.Remove(opendoor);
            choice = remainingDoors[0];
        }

        private int SetOpenDoor() {
            choices.Remove(choice);
            if (choices.Contains(prize)) {
                choices.Remove(prize);
            }
            return choices[0];
        }
    }
}