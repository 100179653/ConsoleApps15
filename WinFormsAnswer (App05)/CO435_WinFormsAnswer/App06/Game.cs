using System;

namespace CO435_WinFormsAnswer
{
    /// The three available choices during the game
    public enum GameChoice
    {
        Rock, 
        Paper,
        Scissors
    }
    /// The two players of the game, we have a 3rd one for error handling 
    public enum GamePlayer
    {
        None,
        Computer,
        Player
    }
    /// <summary>
    /// This class models the Rock-Paper-Scissors 
    /// game and contains all the information on
    /// the state of the game and methods to implement
    /// the basic logic of the game.  It requires
    /// another class to provide the user interface
    /// and control the progress of the game.
    /// </summary>
    /// <author>
    /// Chris Edgley Version 1.0
    /// </author>
    public class Game
    {
        // Players Properties
        public string PlayerName { get; }

        // Public only for Unit testing
        public int PlayerScore { get; set; }

        // Public only for Unit Testing
        public GameChoice PlayerChoice { get; set; }

        // Computer Properties
        public int ComScore { get; set; }
        
        // Public only for Unit Testing
        public GameChoice ComChoice { get; set; }

        // Game Properties
        public int LastRound { get; set; }
        // Round Number
        public int Round { get; set; }
        // Checks who is playing
        public GamePlayer CurrentPlayer { get; set; }
        //Check who is the winner
        public String WinnerRoundName { get; set; }

        // Use seed to get same sequence of random numbers
        private readonly Random generator = new Random(100);
        //This command sets the player's name and runs at the beginning of the game
        public Game(string name)
        {
            this.PlayerName = name;
            PlayerName = "You";
            LastRound = 3;

            StartTheGame();
        }
        //This command starts the game for the user
        public void StartTheGame()
        {
            PlayerScore = 0;
            ComScore = 0;
            Round = 0;
            CurrentPlayer = GamePlayer.Player;
            
        }
        // This command establishes a randomly generated "choice" the computer has
        public void GetComChoice()
        {
            int choice = generator.Next(1, 4);
            
            switch (choice)
            {
                case 1: ComChoice = GameChoice.Rock; break;
                case 2: ComChoice = GameChoice.Paper; break;
                case 3: ComChoice = GameChoice.Scissors; break;
            }
        }
        // This calculates who won on a round and adds it to their score
        public void ScoreRound()
        {
            if ((PlayerChoice == GameChoice.Rock && 
                ComChoice == GameChoice.Paper) ||
               (PlayerChoice == GameChoice.Paper &&                                                                                                       
                ComChoice == GameChoice.Scissors) ||
               (PlayerChoice == GameChoice.Scissors &&
                 ComChoice == GameChoice.Rock))
            {
                ComScore += 2;
                WinnerRoundName = GamePlayer.Computer.ToString();
            }
            else if ((PlayerChoice == GameChoice.Rock &&
                    ComChoice == GameChoice.Scissors) ||
                    (PlayerChoice == GameChoice.Paper) && 
                    (ComChoice == GameChoice.Rock) ||
                    (PlayerChoice == GameChoice.Scissors &&
                    ComChoice == GameChoice.Paper))
            {
                PlayerScore += 2;
                WinnerRoundName = PlayerName;
            }
            else 
            {
                ComScore += 1;
                PlayerScore += 1;
                WinnerRoundName = GamePlayer.None.ToString();
            }

            //this if statement allows us to set a maximum on how many rounds are in place
            // for the game
            if (Round < LastRound) Round++;
            
            else EndTheGame();
            
        }
        //this shows the player who actually won the game
        public void EndTheGame()
        {
            if (ComScore > PlayerScore)
            {
                WinnerRoundName = GamePlayer.Computer.ToString();
            }
            else if (PlayerScore > ComScore)
            {
                WinnerRoundName = PlayerName;
            }
            else WinnerRoundName = "Nobody";

            PlayerScore = 0;
            ComScore = 0;
        }
        // This allows the game to pretty much reset itself from scratch
        public void ResetGame()
        {
            PlayerScore = 0;
            ComScore = 0;
            Round = 1;
            
        }
    }
}
