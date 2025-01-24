using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tic_Tac_Toc_Game.Properties;

namespace Tic_Tac_Toc_Game
{
    public partial class From1 : Form
    {
        public From1()
        {
            InitializeComponent();
        }


        stGameStatus GameStatus;
        enPlayer PlayerTurn = enPlayer.Player1;
        enum enPlayer
        {
            Player1,
            Player2
        }
        enum enWinner
        {
            Player1,
            Player2,
            Draw,
            GameInProgress
        }

        struct stGameStatus
        {
            public enWinner Winner;
            public bool GameOver;
            public sbyte PlayCount;
        }

      
        bool CheckValues(Button btn1, Button btn2, Button btn3)
        {
            if((btn1.Tag.ToString()!="?") && (btn1.Tag.ToString()==btn2.Tag.ToString())
                && (btn2.Tag.ToString() == btn3.Tag.ToString()))
            {
                btn1.BackColor = Color.GreenYellow;
                btn2.BackColor = Color.GreenYellow;
                btn3.BackColor = Color.GreenYellow;

                if (btn1.Tag.ToString() == "X")
                {
                    GameStatus.GameOver = true;
                    GameStatus.Winner = enWinner.Player1;
                    EndGame();
                    return true;
                }
                else
                {
                    GameStatus.GameOver = true;
                    GameStatus.Winner = enWinner.Player2;
                    EndGame();
                    return true;
                }
            }


            return false;
        }

        void EndGame()
        {
            lblTurn.Text = "Game Over";

            switch (GameStatus.Winner)
            {
                case enWinner.Player1:
                    lblWinner.Text = "   Player 1";
                    break;

                case enWinner.Player2:
                    lblWinner.Text = "   Player 2";
                    break;

                default:
                    lblWinner.Text = "   Draw";
                    break;

            }

            MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        void CheckWinner()
        {

           if( CheckValues(button1, button2, button3))
                return;

            if(CheckValues(button4, button5, button6))
                return;

            if (CheckValues(button7, button8, button9))
                return;

            if (CheckValues(button1, button4, button7))
                return;

            if (CheckValues(button2, button5, button8))
                return;

            if (CheckValues(button3, button6, button9))
                return;

            if (CheckValues(button1, button5, button9))
                return;

            if (CheckValues(button3, button5, button7))
                return;
        }
        
        void ChangeImage(Button Btn)
        {
            if (GameStatus.GameOver)
                return;

            if (Btn.Tag.ToString()=="?")
            {
                switch (PlayerTurn)
                {
                    case enPlayer.Player1:
                    Btn.Tag = "X";
                    Btn.Image = Resources.X;
                    GameStatus.PlayCount++;
                    PlayerTurn = enPlayer.Player2;
                        lblTurn.Text = " Player 2";
                        CheckWinner();
                        break;

                    case enPlayer.Player2:
                        Btn.Tag = "O";
                        Btn.Image = Resources.O;
                        GameStatus.PlayCount++;
                        PlayerTurn = enPlayer.Player1;
                        lblTurn.Text = " Player 1";
                        CheckWinner();
                        break;
                }

               
            }
            else
            {
                MessageBox.Show("Wrong Choice", "Wrong", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            if (GameStatus.PlayCount == 9)
            {
                GameStatus.GameOver = true;
                EndGame();
            }
        }

        void ResetButton(Button btn)
        {
            btn.Image = Resources.question_mark_96;
            btn.Tag = "?";
            btn.BackColor = Color.Transparent;
        }

        void RestartGame()
        {
            if (GameStatus.PlayCount != 0)

                if (MessageBox.Show("Are you sure you want to Restart Game", 
                    "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    ResetButton(button1);
                    ResetButton(button2);
                    ResetButton(button3);
                    ResetButton(button4);
                    ResetButton(button5);
                    ResetButton(button6);
                    ResetButton(button7);
                    ResetButton(button8);
                    ResetButton(button9);

                    GameStatus.Winner = enWinner.GameInProgress;
                    GameStatus.PlayCount = 0;
                    GameStatus.GameOver = false;
                    lblWinner.Text = "In Progress";
                    lblTurn.Text = " Player 1";
                    PlayerTurn = enPlayer.Player1;   
                    
                }
        }

        private void From1_Load(object sender, EventArgs e)
        {
           
           
        }

        private void From1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White, 12);

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 300, 250, 750, 250);
            e.Graphics.DrawLine(Pen, 300, 380, 750, 380);
            e.Graphics.DrawLine(Pen, 450, 140, 450, 500);
            e.Graphics.DrawLine(Pen, 600, 140, 600, 500);
        }

      
        private void btnRestartGame_Click_1(object sender, EventArgs e)
        {
            RestartGame();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            ChangeImage((Button)sender);
        }
    }
}
