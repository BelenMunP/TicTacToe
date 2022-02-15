using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GameTutorial1
{
    public partial class MainPage : ContentPage
    {
        private bool player1 = true;
        private int[,] gameBoard = new int[3,3] { { 0, 0, 0 }, { 0, 0, 0 }, { 0, 0, 0 } };

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button00_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button00.BackgroundColor = Color.Red;
                gameBoard[0, 0] = 1;
            }
            else
            {
                Button00.BackgroundColor = Color.Green;
                gameBoard[0, 0] = 2;
            }
            Button00.IsEnabled = false;
            player1 = !player1;
            CheckMovement();
        }

        private void Button01_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button01.BackgroundColor = Color.Red;
                gameBoard[0, 1] = 1;
            }
            else
            {
                Button01.BackgroundColor = Color.Green;
                gameBoard[0, 1] = 2;
            }
            Button01.IsEnabled = false;
            player1 = !player1;
            CheckMovement();
        }

        private void Button02_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button02.BackgroundColor = Color.Red;
                gameBoard[0, 2] = 1;
            }
            else
            {
                Button02.BackgroundColor = Color.Green;
                gameBoard[0, 2] = 2;
            }
            Button02.IsEnabled = false;
            player1 = !player1;
            CheckMovement();
        }

        private void Button10_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button10.BackgroundColor = Color.Red;
                gameBoard[1, 0] = 1;
            }
            else
            {
                Button10.BackgroundColor = Color.Green;
                gameBoard[1, 0] = 2;
            }
            player1 = !player1;
            Button10.IsEnabled = false;
            CheckMovement();
        }

        private void Button11_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button11.BackgroundColor = Color.Red;
                gameBoard[1, 1] = 1;
            }
            else
            {
                Button11.BackgroundColor = Color.Green;
                gameBoard[1, 1] = 2;
            }
            player1 = !player1;
            Button11.IsEnabled = false;
            CheckMovement();
        }

        private void Button12_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button12.BackgroundColor = Color.Red;
                gameBoard[1, 2] = 1;
            }
            else
            {
                Button12.BackgroundColor = Color.Green;
                gameBoard[1, 2] = 2;
            }
            player1 = !player1;
            Button12.IsEnabled = false;
            CheckMovement();
        }

        private void Button20_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button20.BackgroundColor = Color.Red;
                gameBoard[2, 0] = 1;
            }
            else
            {
                Button20.BackgroundColor = Color.Green;
                gameBoard[2, 0] = 2;
            }
            player1 = !player1;
            Button20.IsEnabled = false;
            CheckMovement();
        }

        private void Button21_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button21.BackgroundColor = Color.Red;
                gameBoard[2, 1] = 1;
            }
            else
            {
                Button21.BackgroundColor = Color.Green;
                gameBoard[2, 1] = 2;
            }
            player1 = !player1;
            Button21.IsEnabled = false;
            CheckMovement();
        }

        private void Button22_Clicked(object sender, EventArgs e)
        {
            if (player1)
            {
                Button22.BackgroundColor = Color.Red;
                gameBoard[2, 2] = 1;
            }
            else
            {
                Button22.BackgroundColor = Color.Green;
                gameBoard[2, 2] = 2;
            }
            player1 = !player1;
            Button22.IsEnabled = false;
            CheckMovement();
        }

        private void Restart_Clicked(object sender, EventArgs e)
        {
            Restart_Game();
        }

        private void CheckMovement()
        {
            int resultCheck = CheckWinner();
            if (resultCheck == 0)
            {
                if (CheckFull())
                {
                    DisplayAlert("FULL BOARD", "The game is over!!", "Restart");
                    Restart_Game();
                }
            } 
            else if (resultCheck == 1)
            {
                DisplayAlert("WINNER", "Player 1 is the winner!!", "Restart");
                Restart_Game();
            }
            else
            {
                DisplayAlert("WINNER", "Player 2 is the winner!!", "Restart");
                Restart_Game();
            }
        }

        private void Restart_Game()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    gameBoard[i, j] = 0;

            Button00.BackgroundColor = Color.Ivory;
            Button01.BackgroundColor = Color.Ivory;
            Button02.BackgroundColor = Color.Ivory;
            Button10.BackgroundColor = Color.Ivory;
            Button11.BackgroundColor = Color.Ivory;
            Button12.BackgroundColor = Color.Ivory;
            Button20.BackgroundColor = Color.Ivory;
            Button21.BackgroundColor = Color.Ivory;
            Button22.BackgroundColor = Color.Ivory;
            Button00.IsEnabled = true;
            Button01.IsEnabled = true;
            Button02.IsEnabled = true;
            Button10.IsEnabled = true;
            Button11.IsEnabled = true;
            Button12.IsEnabled = true;
            Button20.IsEnabled = true;
            Button21.IsEnabled = true;
            Button22.IsEnabled = true;

            player1 = true;
        }

        private int CheckWinner()
        {
            // Upper Horizontal line
            if (gameBoard[0,0] > 0 && gameBoard[0, 0] == gameBoard[0, 1] && gameBoard[0, 1] == gameBoard[0, 2])
                return gameBoard[0, 0];
            // Medium Horizontal line
            if (gameBoard[1, 0] > 0 && gameBoard[1, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[1, 2])
                return gameBoard[1, 0];
            // Lower Horizontal line
            if (gameBoard[2, 0] > 0 && gameBoard[2, 0] == gameBoard[2, 1] && gameBoard[2, 1] == gameBoard[2, 2])
                return gameBoard[2, 0];
            // Left Vertical line
            if (gameBoard[0, 0] > 0 && gameBoard[0, 0] == gameBoard[1, 0] && gameBoard[1, 0] == gameBoard[2, 0])
                return gameBoard[0, 0];
            // Medium Vertical line
            if (gameBoard[0, 1] > 0 && gameBoard[0, 1] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 1])
                return gameBoard[0, 1];
            // Right Vertical line
            if (gameBoard[0, 2] > 0 && gameBoard[0, 2] == gameBoard[1, 2] && gameBoard[1, 2] == gameBoard[2, 2])
                return gameBoard[0, 2];
            // Diagonal 1
            if (gameBoard[0, 0] > 0 && gameBoard[0, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[2, 2])
                return gameBoard[0, 0];
            // Diagonal 2
            if (gameBoard[2, 0] > 0 && gameBoard[2, 0] == gameBoard[1, 1] && gameBoard[1, 1] == gameBoard[0, 2])
                return gameBoard[2, 0];

            return 0;
        }

        private bool CheckFull()
        {
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    if (gameBoard[i, j] == 0)
                        return false;

            return true;
        }
    }
}
