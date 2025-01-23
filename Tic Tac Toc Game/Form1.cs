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

        struct stPlayer
        {
            public string Name;
            public char Symbol;
            public Image image;
        }

        stPlayer Player1;
        stPlayer Player2;
         
        void ChangeTurn()
        {
            if (lblTurn.Text == Player1.Name)
                lblTurn.Text = Player2.Name;
            else
                lblTurn.Text = Player1.Name;
        }

        bool CheckPossibleChoice(PictureBox pb)
        {
            if (pb.Tag == null)
                return true;
            else
                MessageBox.Show("Wrong Choice", "Wrong",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return false;
        }
 
        void GameOver()
        {
            MessageBox.Show("Game Over", "GameOver", MessageBoxButtons.OK, MessageBoxIcon.Information);
            pb1.Enabled= false;
            pb2.Enabled= false;
            pb3.Enabled= false;
            pb4.Enabled= false;
            pb5.Enabled= false;
            pb6.Enabled= false;
            pb7.Enabled= false;
            pb8.Enabled= false;
            pb9.Enabled= false;
        }

        void WinChanges(PictureBox pb1,PictureBox pb2,PictureBox pb3)
        {
            pb1.BackColor = Color.Lime;
            pb2.BackColor = Color.Lime;
            pb3.BackColor = Color.Lime;

            lblWinner.Text = "   "+ lblTurn.Text;
            GameOver();
        }

        void DrawChanges()
        {
            GameOver();
            lblWinner.Text = "    Draw";
        }

        bool CheckWin()
        {
            if (pb1.Tag != null && (pb1.Tag.Equals(pb2.Tag)) && (pb1.Tag.Equals(pb3.Tag))) 
            {
                WinChanges(pb1, pb2, pb3);
                return true;
            }

            if (pb4.Tag != null && (pb4.Tag.Equals(pb5)) && (pb4.Tag.Equals(pb6)))
            {
                WinChanges(pb4, pb5, pb6);
                return true;
            }

            if (pb7.Tag != null && (pb7.Tag.Equals(pb8.Tag)) && (pb7.Tag.Equals(pb9.Tag)))
            {
                WinChanges(pb7, pb8, pb9);
                return true;
            }

            if ((pb1.Tag != null) && (pb1.Tag.Equals(pb4.Tag)) && (pb1.Tag.Equals(pb7.Tag)))
            {
                WinChanges(pb1, pb4, pb7);
                return true;
            }

            if (pb2.Tag != null && (pb2.Tag.Equals(pb5.Tag)) && (pb2.Tag.Equals(pb8.Tag) ))
            {
                WinChanges(pb2, pb5, pb8);
                return true;
            }

            if (pb3.Tag != null && (pb3.Tag.Equals(pb6.Tag)) && (pb3.Tag.Equals(pb9.Tag)))
            {
                WinChanges(pb3, pb6, pb9);
                return true;
            }

            if (pb1.Tag != null && (pb1.Tag.Equals(pb5.Tag)) && (pb1.Tag.Equals(pb9.Tag)))
            {
                WinChanges(pb1, pb5, pb9);
                return true;
            }

            if (pb3.Tag != null && (pb3.Tag.Equals(pb5.Tag)) && (pb3.Tag.Equals(pb7.Tag)))
            {
                WinChanges(pb3, pb5, pb7);
                return true;
            }

            return false;
        }

        bool IsGameOver()
        {

            if (CheckWin())
                return true;

            if (Convert.ToSByte(lblWinner.Tag) == 9)
            {
                DrawChanges();
                return true;
            }
                

            return false;
        }
        
        void Choice(PictureBox pb)
        {
            if (CheckPossibleChoice(pb))
            {
                if (lblTurn.Text == Player1.Name)
                {
                    pb.Image = Player1.image;
                    pb.Tag = Player1.Symbol;

                }
                else
                {
                    pb.Image = Player2.image;
                    pb.Tag = Player2.Symbol;
                }

                lblWinner.Tag = Convert.ToSByte(lblWinner.Tag) + 1;

                if (!IsGameOver())
                    ChangeTurn();
            }
        }

        void RestartPbBox(PictureBox pb)
        {
            pb.Image = Resources.question_mark_96;
            pb.Tag = null;
            pb.BackColor = Color.Black;
            pb.Enabled = true;
        }

        void RestartGame()
        {
            if (Convert.ToSByte(lblWinner.Tag) != 0)

                if (MessageBox.Show("Are you sure you want to Restart Game", 
                    "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question,
                    MessageBoxDefaultButton.Button2) == DialogResult.OK)
                {
                    lblWinner.Tag = 0;
                    lblWinner.Text = "In Progress";
                    lblTurn.Text = "Player1";
                    RestartPbBox(pb1);
                    RestartPbBox(pb2);
                    RestartPbBox(pb3);
                    RestartPbBox(pb4);
                    RestartPbBox(pb5);
                    RestartPbBox(pb6);
                    RestartPbBox(pb7);
                    RestartPbBox(pb8);
                    RestartPbBox(pb9);
                }
        }

        private void From1_Load(object sender, EventArgs e)
        {
            Player1 = new stPlayer();

            Player1.Name = "Player1";
            Player1.Symbol = 'x';
            Player1.image = Resources.X;

            Player2 = new stPlayer();

            Player2.Name = "Player2";
            Player2.Symbol = 'O';
            Player2.image = Resources.O;

            lblTurn.Text = Player1.Name;
           
        }

        private void From1_Paint(object sender, PaintEventArgs e)
        {
            Color White = Color.White;
            Pen Pen = new Pen(White, 10);

            Pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            Pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

            e.Graphics.DrawLine(Pen, 300, 250, 750, 250);
            e.Graphics.DrawLine(Pen, 300, 380, 750, 380);
            e.Graphics.DrawLine(Pen, 450, 140, 450, 500);
            e.Graphics.DrawLine(Pen, 600, 140, 600, 500);
        }

        private void pb0_0_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);        
        }

        private void pb0_1_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb0_2_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb1_0_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb1_1_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb1_2_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb2_0_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb2_1_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }

        private void pb2_2_Click(object sender, EventArgs e)
        {
            Choice((PictureBox)sender);
        }


        private void btnRestartGame_Click_1(object sender, EventArgs e)
        {
            RestartGame();
        }
    }
}
