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
    public partial class TicTacToe : Form
    {
        int Turn = 1, FilledCells = 0, InitialRounds;
        int[] A = new int[9];
        Bitmap[] B = new Bitmap[9];
        Graphics[] G = new Graphics[9];

        private void Verify(int N)
        {
            bool Done = false;
            Pen pen = new Pen(Color.Black, 3);
            A[N] = Turn;
            FilledCells++;
            if (N == 0 || N == 1 || N == 2 && Done == false)
            {
                if (A[0] == A[1] && A[1] == A[2] && A[0] != 0)
                {
                    G[0].DrawLine(pen, 5, 100, 200, 100);
                    G[1].DrawLine(pen, 0, 100, 200, 100);
                    G[2].DrawLine(pen, 0, 100, 195, 100);
                    Done = true;
                }
            }
            if (N == 0 || N == 3 || N == 6 && Done == false)
            {
                if (A[0] == A[3] && A[3] == A[6] && A[0] != 0)
                {
                    G[0].DrawLine(pen, 100, 5, 100, 200);
                    G[3].DrawLine(pen, 100, 0, 100, 200);
                    G[6].DrawLine(pen, 100, 0, 100, 195);
                    Done = true;
                }
            }
            if (N == 0 || N == 4 || N == 8 && Done == false)
            {
                if (A[0] == A[4] && A[4] == A[8] && A[0] != 0)
                {
                    G[0].DrawLine(pen, 5, 5, 200, 200);
                    G[4].DrawLine(pen, 0, 0, 200, 200);
                    G[8].DrawLine(pen, 0, 0, 195, 195);
                    Done = true;
                }
            }
            if (N == 1 || N == 4 || N == 7 && Done == false)
            {
                if (A[1] == A[4] && A[4] == A[7] && A[1] != 0)
                {
                    G[1].DrawLine(pen, 100, 5, 100, 200);
                    G[4].DrawLine(pen, 100, 0, 100, 200);
                    G[7].DrawLine(pen, 100, 0, 100, 195);
                    Done = true;
                }
            }
            if (N == 2 || N == 5 || N == 8 && Done == false)
            {
                if (A[2] == A[5] && A[5] == A[8] && A[2] != 0)
                {
                    G[2].DrawLine(pen, 100, 5, 100, 200);
                    G[5].DrawLine(pen, 100, 0, 100, 200);
                    G[8].DrawLine(pen, 100, 0, 100, 195);
                    Done = true;
                }
            }
            if (N == 3 || N == 4 || N == 5 && Done == false)
            {
                if (A[3] == A[4] && A[4] == A[5] && A[3] != 0)
                {
                    G[3].DrawLine(pen, 5, 100, 200, 100);
                    G[4].DrawLine(pen, 0, 100, 200, 100);
                    G[5].DrawLine(pen, 0, 100, 195, 100);
                    Done = true;
                }
            }
            if (N == 6 || N == 7 || N == 8 && Done == false)
            {
                if (A[6] == A[7] && A[7] == A[8] && A[6] != 0)
                {
                    G[6].DrawLine(pen, 5, 100, 200, 100);
                    G[7].DrawLine(pen, 0, 100, 200, 100);
                    G[8].DrawLine(pen, 0, 100, 195, 100);
                    Done = true;
                }
            }
            if (N == 2 || N == 4 || N == 6 && Done == false)
            {
                if (A[2] == A[4] && A[4] == A[6] && A[2] != 0)
                {
                    G[2].DrawLine(pen, 195, 5, 0, 200);
                    G[4].DrawLine(pen, 200, 0, 0, 200);
                    G[6].DrawLine(pen, 200, 0, 5, 195);
                    Done = true;
                }
            }

            if (Done == true)
            {
                Cell_1.Refresh();
                Cell_2.Refresh();
                Cell_3.Refresh();
                Cell_4.Refresh();
                Cell_5.Refresh();
                Cell_6.Refresh();
                Cell_7.Refresh();
                Cell_8.Refresh();
                Cell_9.Refresh();

                for (int i = 0; i < 9; ++i)
                    A[i] = 0;
                Rounds.Number--;
                NoRoundsLeft.Text = Rounds.Number.ToString();
                FilledCells = 0;

                if (Rounds.Number == 0)
                {
                    if (Turn == 1)
                    {
                        P1.Score++;
                        Player1Score.Text = P1.Score.ToString();
                    }
                    else if (Turn == 2)
                    {
                        P2.Score++;
                        Player2Score.Text = P2.Score.ToString();
                    }
                    if (P1.Score > P2.Score)
                        MessageBox.Show(P1.Name + " has won the game!");
                    else if (P1.Score < P2.Score)
                        MessageBox.Show(P2.Name + " has won the game!");
                    else
                        MessageBox.Show("The game ends in a draw!");
                }

                else if (Turn == 1)
                {
                    MessageBox.Show(P1.Name + " has won the round!");
                    P1.Score++;
                    Player1Score.Text = P1.Score.ToString();
                    TurnPlayerName.Text = P2.Name;
                    Turn = 2;
                }

                else if (Turn == 2)
                {
                    MessageBox.Show(P2.Name + " has won the round!");
                    P2.Score++;
                    Player2Score.Text = P2.Score.ToString();
                    TurnPlayerName.Text = P1.Name;
                    Turn = 1;
                }

                for (int i = 0; i < 9; ++i)
                    G[i].Clear(Color.White);
                Cell_1.Refresh();
                Cell_2.Refresh();
                Cell_3.Refresh();
                Cell_4.Refresh();
                Cell_5.Refresh();
                Cell_6.Refresh();
                Cell_7.Refresh();
                Cell_8.Refresh();
                Cell_9.Refresh();
            }
            else if (FilledCells == 9)
            {
                Cell_1.Refresh();
                Cell_2.Refresh();
                Cell_3.Refresh();
                Cell_4.Refresh();
                Cell_5.Refresh();
                Cell_6.Refresh();
                Cell_7.Refresh();
                Cell_8.Refresh();
                Cell_9.Refresh();

                if (Rounds.Number == 0)
                {
                    if (P1.Score > P2.Score)
                        MessageBox.Show(P1.Name + " has won the game!");
                    else if (P1.Score < P2.Score)
                        MessageBox.Show(P2.Name + " has won the game!");
                    else
                        MessageBox.Show("The game ends in a draw!");
                }
                else
                    MessageBox.Show("The round ends in a draw!");

                for (int i = 0; i < 9; ++i)
                    A[i] = 0;
                Rounds.Number--;
                NoRoundsLeft.Text = Rounds.Number.ToString();
                FilledCells = 0;

                for (int i = 0; i < 9; ++i)
                    G[i].Clear(Color.White);
                Cell_1.Refresh();
                Cell_2.Refresh();
                Cell_3.Refresh();
                Cell_4.Refresh();
                Cell_5.Refresh();
                Cell_6.Refresh();
                Cell_7.Refresh();
                Cell_8.Refresh();
                Cell_9.Refresh();
            }
            else if (Turn == 1)
            {
                Turn = 2;
                TurnPlayerName.Text = P2.Name;
            }
            else
            {
                Turn = 1;
                TurnPlayerName.Text = P1.Name;
            }
        }

        private void DrawX(int N, string color)
        {
            Point P1 = new Point(20, 20), P2 = new Point(180, 180), P3 = new Point(180, 20), P4 = new Point(20, 180);
            Pen P = new Pen(Color.Blue, 2);
            if (color == "Green")
                P.Color = Color.Green;
            else if (color == "Red")
                P.Color = Color.Red;
            else if (color == "Yellow")
                P.Color = Color.Yellow;
            G[N].DrawLine(P, P1, P2);
            G[N].DrawLine(P, P3, P4);
        }

        private void DrawO(int N, string color)
        {
            Rectangle R = new Rectangle(20, 20, 160, 160);
            Pen P = new Pen(Color.Blue, 2);
            if (color == "Green")
                P.Color = Color.Green;
            else if (color == "Red")
                P.Color = Color.Red;
            else if (color == "Yellow")
                P.Color = Color.Yellow;
            G[N].DrawEllipse(P, R);
        }

        public TicTacToe()
        {
            InitializeComponent();
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; ++i)
                B[i] = new Bitmap(200, 200);
            Cell_1.Image = B[0];
            Cell_2.Image = B[1];
            Cell_3.Image = B[2];
            Cell_4.Image = B[3];
            Cell_5.Image = B[4];
            Cell_6.Image = B[5];
            Cell_7.Image = B[6];
            Cell_8.Image = B[7];
            Cell_9.Image = B[8];
            for (int i = 0; i < 9; ++i)
                G[i] = Graphics.FromImage(B[i]);
        }

        private void Setup_Game_Click(object sender, EventArgs e)
        {
            Settings S = new Settings();
            S.ShowDialog();
            if (Valid.valid == true)
            {
                ScoreP1.Text = P1.Name + "'s Score:";
                ScoreP2.Text = P2.Name + "'s Score:";
                P1.Score = P2.Score = 0;
                for (int i = 0; i < 9; ++i)
                    G[i].Clear(Color.White);
                Cell_1.Refresh();
                Cell_2.Refresh();
                Cell_3.Refresh();
                Cell_4.Refresh();
                Cell_5.Refresh();
                Cell_6.Refresh();
                Cell_7.Refresh();
                Cell_8.Refresh();
                Cell_9.Refresh();
                Player1Score.Text = Player2Score.Text = "0";
                NoRoundsLeft.Text = Rounds.Number.ToString();
                TurnPlayerName.Text = P1.Name;
                Turn = 1;
                for (int i = 0; i < 9; ++i)
                    A[i] = 0;
                FilledCells = 0;
                InitialRounds = Rounds.Number;
            }
        }

        private void StartOver_Click(object sender, EventArgs e)
        {
            P1.Score = P2.Score = 0;
            for (int i = 0; i < 9; ++i)
                G[i].Clear(Color.White);
            Cell_1.Refresh();
            Cell_2.Refresh();
            Cell_3.Refresh();
            Cell_4.Refresh();
            Cell_5.Refresh();
            Cell_6.Refresh();
            Cell_7.Refresh();
            Cell_8.Refresh();
            Cell_9.Refresh();
            Player1Score.Text = Player2Score.Text = "0";
            NoRoundsLeft.Text = InitialRounds.ToString();
            Rounds.Number = InitialRounds;
            TurnPlayerName.Text = P1.Name;
            Turn = 1;
            for (int i = 0; i < 9; ++i)
                A[i] = 0;
            FilledCells = 0;
        }

        private void Cell_1_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[0] == 0 && Rounds.Number > 0)
            { 
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(0, P1.Color);
                    else
                        DrawO(0, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(0, P2.Color);
                    else
                        DrawO(0, P2.Color);
                }
                Verify(0);
            }
            Cell_1.Refresh();
        }

        private void Cell_2_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[1] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(1, P1.Color);
                    else
                        DrawO(1, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(1, P2.Color);
                    else
                        DrawO(1, P2.Color);
                }
                Verify(1);
            }
            Cell_2.Refresh();
        }

        private void Cell_3_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[2] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(2, P1.Color);
                    else
                        DrawO(2, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(2, P2.Color);
                    else
                        DrawO(2, P2.Color);
                }
                Verify(2);
            }
            Cell_3.Refresh();
        }

        private void Cell_4_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[3] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(3, P1.Color);
                    else
                        DrawO(3, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(3, P2.Color);
                    else
                        DrawO(3, P2.Color);
                }
                Verify(3);
            }
            Cell_4.Refresh();
        }

        private void Cell_5_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[4] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(4, P1.Color);
                    else
                        DrawO(4, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(4, P2.Color);
                    else
                        DrawO(4, P2.Color);
                }
                Verify(4);
            }
            Cell_5.Refresh();
        }

        private void Cell_6_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[5] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(5, P1.Color);
                    else
                        DrawO(5, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(5, P2.Color);
                    else
                        DrawO(5, P2.Color);
                }
                Verify(5);
            }
            Cell_6.Refresh();
        }

        private void Cell_7_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[6] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(6, P1.Color);
                    else
                        DrawO(6, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(6, P2.Color);
                    else
                        DrawO(6, P2.Color);
                }
                Verify(6);
            }
            Cell_7.Refresh();
        }

        private void Cell_8_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[7] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(7, P1.Color);
                    else
                        DrawO(7, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(7, P2.Color);
                    else
                        DrawO(7, P2.Color);
                }
                Verify(7);
            }
            Cell_8.Refresh();
        }

        private void Cell_9_Click(object sender, EventArgs e)
        {
            if (Valid.valid == true && A[8] == 0 && Rounds.Number > 0)
            {
                if (Turn == 1)
                {
                    if (P1.Symbol == true)
                        DrawX(8, P1.Color);
                    else
                        DrawO(8, P1.Color);
                }
                else
                {
                    if (P2.Symbol == true)
                        DrawX(8, P2.Color);
                    else
                        DrawO(8, P2.Color);
                }
                Verify(8);
            }
            Cell_9.Refresh();
        }

    }
}
