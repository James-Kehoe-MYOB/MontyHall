using MontyHall;

namespace MontyHallTests {
    public class Stub_MontyHallGame : IMontyHallGame {
        public int changeDoorCount = 0;
        public bool hasWon() {
            return true;
        }

        public void ChangeDoor() {
            changeDoorCount++;
        }
    }
}