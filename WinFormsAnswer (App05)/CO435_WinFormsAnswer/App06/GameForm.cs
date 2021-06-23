using CO435_WinFormsAnswer.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace CO435_WinFormsAnswer
{
    // This contains all of the data needed for the form to load correctly
    public partial class GameForm : Form
    {
        private Bitmap rockBitmap = new Bitmap(Resources.Rock);
        private Bitmap paperBitmap = new Bitmap(Resources.Paper);
        private Bitmap scissorsBitmap = new Bitmap(Resources.Scissors);

        private Game game = new Game("Player");

        // When the program loads this game,  it displays rock as default
        // Then display the rock image as a default 
        public GameForm()
        {
            InitializeComponent();
            DisplayImage(userPictureBox, rockBitmap);
            DisplayImage(comPictureBox, rockBitmap);
            RoundDisplay();
            game.StartTheGame();

        }
        //This allows the picture boxes to display what image I need
        private void DisplayImage(PictureBox pictureBox, Bitmap bitmap)
        {
            pictureBox.Image = bitmap;
        }

        //This allows the picture boxes to display a rock and set the player's
        //choice into a rock
        private void DisplayRock(object sender, EventArgs e)
        {
            DisplayImage(userPictureBox, rockBitmap);
            game.PlayerChoice = GameChoice.Rock;
        }
        //This allows the picture boxes to display some paper and set the player's
        //choice into some paper
        private void DisplayPaper(object sender, EventArgs e)
        {
            DisplayImage(userPictureBox, paperBitmap);
            game.PlayerChoice = GameChoice.Paper;

        }
        //This allows the picture boxes to display some paper and set the player's
        //choice into some paper
        private void DisplayScissors(object sender, EventArgs e)
        {
            DisplayImage(userPictureBox, scissorsBitmap);
            game.PlayerChoice = GameChoice.Scissors;
        }
        //This allows us to cshow to the player what the Computer "chose"
        private void GetComputerChoice(object sender, EventArgs e)
        {
            game.GetComChoice();

            if (game.ComChoice == GameChoice.Rock)
            {
                DisplayImage(comPictureBox, rockBitmap);
            }
            else if (game.ComChoice == GameChoice.Paper)
            {
                DisplayImage(comPictureBox, paperBitmap);
            }
            else if (game.ComChoice == GameChoice.Scissors)
            {
                DisplayImage(comPictureBox, scissorsBitmap);
            }

            DisplayRoundWinner();
        }
        // This calculates who is the winner of one round
        private void DisplayRoundWinner()
        {
            game.ScoreRound();

            string message = "You chose " + game.PlayerChoice + "\n";

            message = message + "\nComputer Chose " + game.ComChoice + "\n";

            message = message + "\n The Winner is " + game.WinnerRoundName + "\n\n";

            scoreRichTextBox.AppendText(message);
            scoreRichTextBox.ScrollToCaret();
            RoundDisplay();
            if (game.Round == game.LastRound)
            {
                ResetGame();
            }

        }
        // This shows who is the winner of all the game
        private void DisplayGameWinner()
        {
            if (game.PlayerScore > game.ComScore)
            {
                scoreRichTextBox.AppendText("The Human Player Wins!");
                scoreRichTextBox.ScrollToCaret();
                game.Round = 0;
                RoundDisplay();
            }
            else if (game.PlayerScore == game.ComScore)
            {
                scoreRichTextBox.AppendText("It's a tie! Everyone Loses!");
                scoreRichTextBox.ScrollToCaret();
                game.Round = 0;
                RoundDisplay();
            }
            else if (game.PlayerScore < game.ComScore)
            {
                scoreRichTextBox.AppendText("The Computers have won!");
                scoreRichTextBox.ScrollToCaret();
                game.Round = 0;
                RoundDisplay();
            }
            else
            {
                scoreRichTextBox.AppendText("Contact Technical Support!");
            }
        }
        //this allows the form to quit
        private void QuitForm(object sender, EventArgs e)
        {
            Close();
        }
        // This allows the label to display which round you are on 
        private void RoundDisplay()
        {
            lblRoundNo.Text = "Round:" + game.Round;
        }
        // This allows the user a choice to reset the game
        public void ResetGame()
        {
            DisplayGameWinner();
            DialogResult result1 = MessageBox.Show("Do you want to play again?",
                "Reset Query",
                MessageBoxButtons.YesNo);
            if (result1 == DialogResult.Yes)
            {
                game.ResetGame();
                scoreRichTextBox.Text = String.Empty;
                game.Round = 0;

            }
            else if (result1 == DialogResult.No)
            {
                MessageBox.Show("Thank you so much for playing my game!", "Goodbye!");
                Close();
            }

        }

    }
}
