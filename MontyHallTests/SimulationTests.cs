using MontyHall;
using Xunit;

namespace MontyHallTests {
    public class SimulationTests {
        [Fact(DisplayName = "Can run game correct number of times")]
        public void CanRunGameCorrectNumberOfTimes() {
            int testGames = 500;
            //Arrange
            Simulator simulator = new Simulator(testGames, true, new MontyHallGame(2, new RandomDoorSelector()));
            
            //Act
            int numberofgames = simulator.wins + simulator.losses;
            
            //Assert
            Assert.Equal(testGames, numberofgames);

        }
        
        [Fact (DisplayName = "Simulation makes correct decision every time")]
        public void SimulationMakesCorrectDecisionEveryTime() {
            var stubGame = new Stub_MontyHallGame();
            bool willChange = true;
            int testGames = 500;
            Simulator simulator = new Simulator(testGames, willChange, stubGame);
            
            Assert.Equal(stubGame.changeDoorCount, testGames);
            
        }
        
        [Fact (DisplayName = "Simulation makes correct decision every time")]
        public void SimulationMakesFalseDecisionEveryTime() {
            var stubGame = new Stub_MontyHallGame();
            bool willChange = false;
            int testGames = 500;
            Simulator simulator = new Simulator(testGames, willChange, stubGame);
            
            Assert.Equal(0, stubGame.changeDoorCount);
            
        }
        
        [Fact (DisplayName = "Simulation should keep track of results")]
        public void SimulationShouldKeepTrackOfResults() {
            
        }
    }
}