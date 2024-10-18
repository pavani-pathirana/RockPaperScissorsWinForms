using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            pbPlayerChoice.SizeMode = PictureBoxSizeMode.Zoom;    // For player's choice
            pbComputerChoice.SizeMode = PictureBoxSizeMode.Zoom;  // For computer's choice
            pbResult.SizeMode = PictureBoxSizeMode.Zoom;
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
            pbPlayerChoice.Image = null;
            pbComputerChoice.Image = null;
            pbResult.Image = null;
        }

        private void PlayGame(string playerChoice)
        {
            string[] choices = { "rock", "paper", "scissors" };
            string computerChoice = choices[random.Next(choices.Length)];

            // Set images based on player's choice
            pbPlayerChoice.Image = GetChoiceImage(playerChoice);
            pbComputerChoice.Image = GetChoiceImage(computerChoice);

            string result = DetermineWinner(playerChoice, computerChoice);
            lblResult.Text = $"You chose {playerChoice}, Computer chose {computerChoice}. {result}";

            pbResult.Image = GetResultImage(result);
            UpdateScore();

            // Briefly show the result image for effect
            pbResult.Visible = true;
            Timer timer = new Timer();
            timer.Interval = 500; // 0.5 seconds
            timer.Tick += (s, e) =>
            {
                pbResult.Visible = false;
                timer.Stop();
            };
            timer.Start();
        }

        private Image GetChoiceImage(string choice)
        {
            switch (choice)
            {
                case "rock":
                    return ConvertToImage(Properties.Resources.rock);
                case "paper":
                    return ConvertToImage(Properties.Resources.paper);
                case "scissors":
                    return ConvertToImage(Properties.Resources.scissors);
                default:
                    return null;
            }
        }

        private Image GetResultImage(string result)
        {
            if (result.Contains("win"))
                return ConvertToImage(Properties.Resources.win); // Ensure "win" is in resources
            if (result.Contains("lose"))
                return ConvertToImage(Properties.Resources.lose);
            return ConvertToImage(Properties.Resources.tie); // Ensure "tie" is in resources
        }

        private Image ConvertToImage(byte[] imageData)
        {
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                return Image.FromStream(ms);
            }
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
            lblScore.Text = $"Score: Player {playerScore} - {computerScore} Computer";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Centering the result label and score on the form
            lblResult.TextAlign = ContentAlignment.MiddleCenter;
            lblScore.TextAlign = ContentAlignment.MiddleCenter;

            // Setting initial text
            lblResult.Text = "Choose Rock, Paper, or Scissors!";
            lblScore.Text = $"Score: Player {playerScore} - {computerScore} Computer";

            // Make sure the result picture box is hidden initially
            pbResult.Visible = false;
        }

        private void pbComputerChoice_Click(object sender, EventArgs e)
        {

        }
    }
}