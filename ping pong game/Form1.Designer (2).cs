namespace ping_pong_game
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timer_Movement = new System.Windows.Forms.Timer(this.components);
            this.pb_Player = new System.Windows.Forms.PictureBox();
            this.pb_Enemy = new System.Windows.Forms.PictureBox();
            this.pb_Ball = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pb_Ball);
            this.panel1.Location = new System.Drawing.Point(354, 156);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(143, 75);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pb_Player
            // 
            this.pb_Player.Image = global::ping_pong_game.Properties.Resources.fairy1;
            this.pb_Player.Location = new System.Drawing.Point(684, 156);
            this.pb_Player.Name = "pb_Player";
            this.pb_Player.Size = new System.Drawing.Size(101, 101);
            this.pb_Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Player.TabIndex = 2;
            this.pb_Player.TabStop = false;
            // 
            // pb_Enemy
            // 
            this.pb_Enemy.Image = global::ping_pong_game.Properties.Resources.rocket;
            this.pb_Enemy.Location = new System.Drawing.Point(34, 139);
            this.pb_Enemy.Name = "pb_Enemy";
            this.pb_Enemy.Size = new System.Drawing.Size(100, 92);
            this.pb_Enemy.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Enemy.TabIndex = 1;
            this.pb_Enemy.TabStop = false;
            this.pb_Enemy.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pb_Ball
            // 
            this.pb_Ball.Image = global::ping_pong_game.Properties.Resources.smallcar_png;
            this.pb_Ball.Location = new System.Drawing.Point(3, 0);
            this.pb_Ball.Name = "pb_Ball";
            this.pb_Ball.Size = new System.Drawing.Size(140, 77);
            this.pb_Ball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_Ball.TabIndex = 0;
            this.pb_Ball.TabStop = false;
            this.pb_Ball.Click += new System.EventHandler(this.pb_Ball_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 486);
            this.Controls.Add(this.pb_Player);
            this.Controls.Add(this.pb_Enemy);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pb_Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Enemy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_Ball)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pb_Ball;
        private System.Windows.Forms.Timer timer_Movement;
        private System.Windows.Forms.PictureBox pb_Enemy;
        private System.Windows.Forms.PictureBox pb_Player;
    }
}

