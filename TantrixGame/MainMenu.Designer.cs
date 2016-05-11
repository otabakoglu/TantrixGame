namespace TantrixGame
{
    partial class MainMenu
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
            this.btn_newgame = new System.Windows.Forms.Button();
            this.btn_howtoplay = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // btn_newgame
            // 
            this.btn_newgame.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_newgame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_newgame.FlatAppearance.BorderSize = 2;
            this.btn_newgame.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_newgame.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(244)))), ((int)(((byte)(188)))));
            this.btn_newgame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_newgame.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_newgame.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btn_newgame.Location = new System.Drawing.Point(387, 172);
            this.btn_newgame.Name = "btn_newgame";
            this.btn_newgame.Size = new System.Drawing.Size(132, 60);
            this.btn_newgame.TabIndex = 0;
            this.btn_newgame.Text = "Yeni Oyun";
            this.btn_newgame.UseVisualStyleBackColor = false;
            this.btn_newgame.Click += new System.EventHandler(this.btn_clk_newgame);
            // 
            // btn_howtoplay
            // 
            this.btn_howtoplay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_howtoplay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_howtoplay.FlatAppearance.BorderSize = 2;
            this.btn_howtoplay.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(118)))), ((int)(((byte)(65)))));
            this.btn_howtoplay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(168)))), ((int)(((byte)(136)))));
            this.btn_howtoplay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_howtoplay.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_howtoplay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(67)))), ((int)(((byte)(22)))));
            this.btn_howtoplay.Location = new System.Drawing.Point(387, 269);
            this.btn_howtoplay.Name = "btn_howtoplay";
            this.btn_howtoplay.Size = new System.Drawing.Size(165, 60);
            this.btn_howtoplay.TabIndex = 10;
            this.btn_howtoplay.Text = "Nasıl Oynanır?";
            this.btn_howtoplay.UseVisualStyleBackColor = false;
            this.btn_howtoplay.Click += new System.EventHandler(this.btn_clk_howtoplay);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatAppearance.BorderSize = 2;
            this.btn_exit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            this.btn_exit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_exit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_exit.Location = new System.Drawing.Point(387, 375);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(132, 60);
            this.btn_exit.TabIndex = 11;
            this.btn_exit.Text = "Çıkış";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_clk_exit);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 50;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::TantrixGame.Properties.Resources.menubgnew;
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.btn_newgame);
            this.Controls.Add(this.btn_howtoplay);
            this.Controls.Add(this.btn_exit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainMenu";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "0";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }
       
        #endregion

        private System.Windows.Forms.Button btn_newgame;
        private System.Windows.Forms.Button btn_howtoplay;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Timer timer1;
    }
}