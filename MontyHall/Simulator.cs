namespace MontyHall {
    public class Simulator <TMontyHallGame, TDoorSelector> 
        where TMontyHallGame : IMontyHallGame, new()
        where TDoorSelector : PrizeDoorSelector, new()
        
        {
        private int _numberOfGames;
        public int wins { get; private set; }
        public int losses { get; private set; }

        public Simulator(int numberOfGames, bool willChange) {
            _numberOfGames = numberOfGames;
            for (int i = 0; i < numberOfGames; i++) {
                var selector = new TDoorSelector();
                TMontyHallGame game = new TMontyHallGame();
                if (willChange) {
                    game.ChangeDoor();
                }
                if (game.hasWon()) {
                    wins++;
                }
                else {
                    losses++;
                }
            }
        }

    }
}