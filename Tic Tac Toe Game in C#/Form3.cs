﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TicTacToe
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            resetGame();
        }
        DB a = new DB();
        public enum Player
        {
            X, O
        }
        Player currentPlayer; // calling the player class 
        List<Button> buttons; // creating a LIST or array of buttons
        Random rand = new Random(); // importing the random number generator class
        int playerWins = 0; // set the player win integer to 0
        int computerWins = 0;
        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void playerClick(object sender, EventArgs e)
        {
            var button = (Button)sender; // find which button was clicked
            currentPlayer = Player.X; // set the player to X
            button.Text = currentPlayer.ToString(); // change the button text to player X
            button.Enabled = false; // disable the button
            button.BackColor = System.Drawing.Color.Cyan; // change the player colour to Cyan
            buttons.Remove(button); //remove the button from the list buttons so the AI can't click it either
            Check(); // check if the player won
            AImoves.Start(); // s
        }
        private void loadbuttons()
        {
            // this the custom function which will load all the buttons from the form to the buttons list
            buttons = new List<Button> { button1, button2, button3, button4, button5, button6, button7, button9, button8 };
        }
        private void resetGame()
        {
            //check each of the button with a tag of play
            foreach (Control X in this.Controls)
            {
                if (X is Button && X.Tag == "play")
                {
                    ((Button)X).Enabled = true; // change them all back to enabled or clickable
                    ((Button)X).Text = ""; // set the text to question mark
                    ((Button)X).BackColor = default(Color); // change the background colour to default button colors
                }
            }
            loadbuttons(); // run the load buttons function so all the buttons are inserted back in the array
        }

        private void Check()
        {
            //in this function we will check if the player or the AI has won
            // we have two very large if statements with the winning possibilities
            if (button1.Text == "X" && button2.Text == "X" && button3.Text == "X"
               || button4.Text == "X" && button5.Text == "X" && button6.Text == "X"
               || button7.Text == "X" && button9.Text == "X" && button8.Text == "X"
               || button1.Text == "X" && button4.Text == "X" && button7.Text == "X"
               || button2.Text == "X" && button5.Text == "X" && button8.Text == "X"
               || button3.Text == "X" && button6.Text == "X" && button9.Text == "X"
               || button1.Text == "X" && button5.Text == "X" && button9.Text == "X"
               || button3.Text == "X" && button5.Text == "X" && button7.Text == "X")
            {
                // if any of the above conditions are met
                AImoves.Stop(); //stop the timer
                MessageBox.Show("Player Wins"); // show a message to the player
                playerWins++; // increase the player wins 
                label6.Text = "Player Wins- " + playerWins; // update player label
                resetGame(); // run the reset game function
            }
            // below if statement is for when the AI wins the game
            else if (button1.Text == "O" && button2.Text == "O" && button3.Text == "O"
            || button4.Text == "O" && button5.Text == "O" && button6.Text == "O"
            || button7.Text == "O" && button9.Text == "O" && button8.Text == "O"
            || button1.Text == "O" && button4.Text == "O" && button7.Text == "O"
            || button2.Text == "O" && button5.Text == "O" && button8.Text == "O"
            || button3.Text == "O" && button6.Text == "O" && button9.Text == "O"
            || button1.Text == "O" && button5.Text == "O" && button9.Text == "O"
            || button3.Text == "O" && button5.Text == "O" && button7.Text == "O")
            {
                // if any of the conditions are met above then we will do the following
                // this code will run when the AI wins the game
                AImoves.Stop(); // stop the timer
                MessageBox.Show("Computer Wins") ; // show a message box to say computer won
                computerWins++; // increase the computer wins score number
                label7.Text = "AI Wins- " + computerWins; // update the label 2 for computer wins
                resetGame(); // run the reset game
            }
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = computer.Player1;
            label2.Text = computer.Player2;
        }

      

        private void AImove(object sender, EventArgs e)
        {
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count); // generate a random number within the number of buttons available
                buttons[index].Enabled = false; // assign the number to the button
                // when the random number is generated then we will look into the list
                // for what that number is we select that button
                // for example if the number is 8
                // then we select the 8th button in the list
                currentPlayer = Player.O; // set the AI with O
                buttons[index].Text = currentPlayer.ToString(); // show O on the button
                buttons[index].BackColor = System.Drawing.Color.DarkSalmon; // change the background of the button dark salmon colour
                buttons.RemoveAt(index); // remove that button from the list
                Check(); // check if the AI won anything
                AImoves.Stop(); // stop the AI timer
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {

            String query = "insert into scores(player1_name,player2_name,player1_score,player2_score) values('" + label1.Text + "','" + label2.Text + "','" + label6.Text + "','" + label7.Text + "')";
            SqlCommand cmd = new SqlCommand(query, a.Con());
            a.opencon();
            int resut = cmd.ExecuteNonQuery();
            if (resut > 0)
            {
                MessageBox.Show("Data inserted");
            }
            a.closecon();
            Application.Restart();
        }
    }
}
