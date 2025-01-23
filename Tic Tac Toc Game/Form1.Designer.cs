namespace Tic_Tac_Toc_Game
{
    partial class From1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTurn = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWinner = new System.Windows.Forms.Label();
            this.btnRestartGame = new System.Windows.Forms.Button();
            this.pb1 = new System.Windows.Forms.PictureBox();
            this.pb2 = new System.Windows.Forms.PictureBox();
            this.pb3 = new System.Windows.Forms.PictureBox();
            this.pb4 = new System.Windows.Forms.PictureBox();
            this.pb5 = new System.Windows.Forms.PictureBox();
            this.pb6 = new System.Windows.Forms.PictureBox();
            this.pb7 = new System.Windows.Forms.PictureBox();
            this.pb8 = new System.Windows.Forms.PictureBox();
            this.pb9 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Britannic Bold", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(337, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(404, 74);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tic-Tac-Toe Game";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(96, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 41);
            this.label4.TabIndex = 12;
            this.label4.Text = "Turn";
            // 
            // lblTurn
            // 
            this.lblTurn.AutoSize = true;
            this.lblTurn.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTurn.ForeColor = System.Drawing.Color.White;
            this.lblTurn.Location = new System.Drawing.Point(81, 208);
            this.lblTurn.Name = "lblTurn";
            this.lblTurn.Size = new System.Drawing.Size(155, 41);
            this.lblTurn.TabIndex = 13;
            this.lblTurn.Text = "Player 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(81, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 41);
            this.label3.TabIndex = 15;
            this.label3.Text = "Winner";
            // 
            // lblWinner
            // 
            this.lblWinner.AutoSize = true;
            this.lblWinner.Font = new System.Drawing.Font("Britannic Bold", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWinner.ForeColor = System.Drawing.Color.Lime;
            this.lblWinner.Location = new System.Drawing.Point(53, 316);
            this.lblWinner.Name = "lblWinner";
            this.lblWinner.Size = new System.Drawing.Size(209, 41);
            this.lblWinner.TabIndex = 16;
            this.lblWinner.Tag = "0";
            this.lblWinner.Text = "In Progress";
            // 
            // btnRestartGame
            // 
            this.btnRestartGame.BackColor = System.Drawing.Color.Black;
            this.btnRestartGame.Font = new System.Drawing.Font("Britannic Bold", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestartGame.ForeColor = System.Drawing.Color.White;
            this.btnRestartGame.Location = new System.Drawing.Point(60, 374);
            this.btnRestartGame.Name = "btnRestartGame";
            this.btnRestartGame.Size = new System.Drawing.Size(217, 47);
            this.btnRestartGame.TabIndex = 17;
            this.btnRestartGame.Text = "Restart Game";
            this.btnRestartGame.UseVisualStyleBackColor = false;
            this.btnRestartGame.Click += new System.EventHandler(this.btnRestartGame_Click_1);
            // 
            // pb1
            // 
            this.pb1.BackColor = System.Drawing.Color.Black;
            this.pb1.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb1.Location = new System.Drawing.Point(308, 142);
            this.pb1.Name = "pb1";
            this.pb1.Size = new System.Drawing.Size(122, 96);
            this.pb1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb1.TabIndex = 0;
            this.pb1.TabStop = false;
            this.pb1.Click += new System.EventHandler(this.pb0_0_Click);
            // 
            // pb2
            // 
            this.pb2.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb2.Location = new System.Drawing.Point(464, 142);
            this.pb2.Name = "pb2";
            this.pb2.Size = new System.Drawing.Size(122, 96);
            this.pb2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb2.TabIndex = 1;
            this.pb2.TabStop = false;
            this.pb2.Click += new System.EventHandler(this.pb0_1_Click);
            // 
            // pb3
            // 
            this.pb3.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb3.Location = new System.Drawing.Point(620, 142);
            this.pb3.Name = "pb3";
            this.pb3.Size = new System.Drawing.Size(122, 96);
            this.pb3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb3.TabIndex = 2;
            this.pb3.TabStop = false;
            this.pb3.Click += new System.EventHandler(this.pb0_2_Click);
            // 
            // pb4
            // 
            this.pb4.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb4.Location = new System.Drawing.Point(308, 261);
            this.pb4.Name = "pb4";
            this.pb4.Size = new System.Drawing.Size(122, 96);
            this.pb4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb4.TabIndex = 3;
            this.pb4.TabStop = false;
            this.pb4.Click += new System.EventHandler(this.pb1_0_Click);
            // 
            // pb5
            // 
            this.pb5.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb5.Location = new System.Drawing.Point(464, 261);
            this.pb5.Name = "pb5";
            this.pb5.Size = new System.Drawing.Size(122, 96);
            this.pb5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb5.TabIndex = 4;
            this.pb5.TabStop = false;
            this.pb5.Click += new System.EventHandler(this.pb1_1_Click);
            // 
            // pb6
            // 
            this.pb6.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb6.Location = new System.Drawing.Point(620, 261);
            this.pb6.Name = "pb6";
            this.pb6.Size = new System.Drawing.Size(122, 96);
            this.pb6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb6.TabIndex = 5;
            this.pb6.TabStop = false;
            this.pb6.Click += new System.EventHandler(this.pb1_2_Click);
            // 
            // pb7
            // 
            this.pb7.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb7.Location = new System.Drawing.Point(308, 393);
            this.pb7.Name = "pb7";
            this.pb7.Size = new System.Drawing.Size(122, 96);
            this.pb7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb7.TabIndex = 6;
            this.pb7.TabStop = false;
            this.pb7.Click += new System.EventHandler(this.pb2_0_Click);
            // 
            // pb8
            // 
            this.pb8.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb8.Location = new System.Drawing.Point(464, 393);
            this.pb8.Name = "pb8";
            this.pb8.Size = new System.Drawing.Size(122, 96);
            this.pb8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb8.TabIndex = 7;
            this.pb8.TabStop = false;
            this.pb8.Click += new System.EventHandler(this.pb2_1_Click);
            // 
            // pb9
            // 
            this.pb9.Image = global::Tic_Tac_Toc_Game.Properties.Resources.question_mark_96;
            this.pb9.Location = new System.Drawing.Point(620, 393);
            this.pb9.Name = "pb9";
            this.pb9.Size = new System.Drawing.Size(122, 96);
            this.pb9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb9.TabIndex = 8;
            this.pb9.TabStop = false;
            this.pb9.Click += new System.EventHandler(this.pb2_2_Click);
            // 
            // From1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(838, 549);
            this.Controls.Add(this.pb9);
            this.Controls.Add(this.btnRestartGame);
            this.Controls.Add(this.pb8);
            this.Controls.Add(this.lblWinner);
            this.Controls.Add(this.pb7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pb6);
            this.Controls.Add(this.lblTurn);
            this.Controls.Add(this.pb5);
            this.Controls.Add(this.pb4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.pb3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pb2);
            this.Controls.Add(this.pb1);
            this.ForeColor = System.Drawing.Color.White;
            this.Name = "From1";
            this.Text = "Tic-Tac-Toe Game";
            this.Load += new System.EventHandler(this.From1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.From1_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pb1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTurn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblWinner;
        private System.Windows.Forms.Button btnRestartGame;
        private System.Windows.Forms.PictureBox pb1;
        private System.Windows.Forms.PictureBox pb2;
        private System.Windows.Forms.PictureBox pb3;
        private System.Windows.Forms.PictureBox pb4;
        private System.Windows.Forms.PictureBox pb5;
        private System.Windows.Forms.PictureBox pb6;
        private System.Windows.Forms.PictureBox pb7;
        private System.Windows.Forms.PictureBox pb8;
        private System.Windows.Forms.PictureBox pb9;
    }
}

