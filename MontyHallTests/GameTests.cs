using System;
using MontyHall;
using Xunit;

namespace MontyHallTests {
    public class GameTests {
        [Fact]
        public void CanWinGame() {
            var montyHallGame = new MontyHallGame(1, new Stub_PrizeDoorSelector());
            
            Assert.True(montyHallGame.hasWon());
        }
        
        [Fact]
        public void CanLoseGame() {
            var montyHallGame = new MontyHallGame(3, new Stub_PrizeDoorSelector());
            
            Assert.False(montyHallGame.hasWon());
        }
        
        [Fact]
        public void CanChangeChoice() {
            var montyHallGame = new MontyHallGame(3, new Stub_PrizeDoorSelector());
            montyHallGame.ChangeDoor();
            
            Assert.NotEqual(3, montyHallGame.choice);
        }
    }
}