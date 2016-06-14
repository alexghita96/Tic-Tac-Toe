using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Settings : Form
    {
        

        public Settings()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void StartGame_Click(object sender, EventArgs e)
        {
            bool Ok = true;

            // Player 1 Name
            if (String.IsNullOrEmpty(Player1_Name.Text))
                Ok = false;
            else
                P1.Name = Player1_Name.Text;

            //Player 2 Name
            if (String.IsNullOrEmpty(Player2_Name.Text))
                Ok = false;
            else
                P2.Name = Player2_Name.Text;

            if (P1.Name == P2.Name)
                Ok = false;

            //Player 1 Symbol
            if (String.IsNullOrEmpty(Player1_Symbol.Text))
                Ok = false;
            else if (Player1_Symbol.Text == "X")
            {
                P1.Symbol = true;
                P2.Symbol = false;
            }
            else
            {
                P1.Symbol = false;
                P2.Symbol = true;
            }

            //Player 2 Symbol
            if (String.IsNullOrEmpty(Player2_Symbol.Text))
                Ok = false;
            else if (Player2_Symbol.Text == "X")
            {
                P2.Symbol = true;
                P1.Symbol = false;
            }
            else
            {
                P2.Symbol = false;
                P1.Symbol = true;
            }

            //Player 1 Color
            if (String.IsNullOrEmpty(Player1_Color.Text))
                Ok = false;
            else
                P1.Color = Player1_Color.Text;

            //Player 2 Color
            if (String.IsNullOrEmpty(Player2_Color.Text))
                Ok = false;
            else
                P2.Color = Player2_Color.Text;

            //Reset Scores
            P1.Score = P2.Score = 0;

            //Number of Rounds
            try
            {
                Rounds.Number = Convert.ToInt32(RoundsNo.Text);
            }
            catch
            {
                MessageBox.Show("Please try again.");
                return;
            }
            if (Rounds.Number <= 0)
                Ok = false;

            if (Ok == false)
            {
                MessageBox.Show("Please try again.");
                return;
            }
            else
            {
                Valid.valid = true;
                this.Close();
            }
        }

        private void Player1_Symbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Player1_Symbol.SelectedIndex == 0)
                Player2_Symbol.SelectedIndex = 1;
            else
                Player2_Symbol.SelectedIndex = 0;
        }

        private void Player2_Symbol_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Player2_Symbol.SelectedIndex == 0)
                Player1_Symbol.SelectedIndex = 1;
            else
                Player1_Symbol.SelectedIndex = 0;
        }
    }
}
