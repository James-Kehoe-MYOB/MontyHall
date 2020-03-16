using System;
using MontyHall;
using Xunit;

namespace MontyHallTests {
    public class UnitTest1 {
        [Fact]
        public void CanWinGame() {
            var montyHallGame = new MontyHallGame(1, new Stub_PrizeDoorSelector());
            
            Assert.True(montyHallGame.win);
        }
        
        [Fact]
        public void CanLoseGame() {
            var montyHallGame = new MontyHallGame(3, new Stub_PrizeDoorSelector());
            
            Assert.False(montyHallGame.win);
        }
        
        [Fact]
        public void CanChangeChoice() {
            var montyHallGame = new MontyHallGame(3, new Stub_PrizeDoorSelector());
            montyHallGame.ChangeDoor();
            
            Assert.NotEqual(3, montyHallGame.choice);
        }
    }
}