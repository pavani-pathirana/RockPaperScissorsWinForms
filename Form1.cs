using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsWinForms
{

    
    public partial class Form1 : Form
    {
        private int playerScore = 0;
        private int computerScore = 0;
        private Random random = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            PlayGame("rock");
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            PlayGame("paper");
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            PlayGame("scissors");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            computerScore = 0;
            UpdateScore();
            lblResult.Text = "Choose Rock, Paper, or Scissors!";
        }

        private void PlayGame(string playerChoice)
        {
            string[] choices = { "rock", "paper", "scissors" };
            string computerChoice = choices[random.Next(choices.Length)];

            string result = DetermineWinner(playerChoice, computerChoice);
            lblResult.Text = $"You chose {playerChoice}, Computer chose {computerChoice}. {result}";

            UpdateScore();
        }

        private string DetermineWinner(string player, string computer)
        {
            if (player == computer)
                return "It's a tie!";

            if ((player == "rock" && computer == "scissors") ||
                (player == "scissors" && computer == "paper") ||
                (player == "paper" && computer == "rock"))
            {
                playerScore++;
                return "You win!";
            }
            else
            {
                computerScore++;
                return "You lose!";
            }
        }

        private void UpdateScore()
        {
            lblScore.Text = $"Score: {playerScore} - {computerScore}";
        }
    }
}
