namespace Snake
{
    partial class FRMsnake
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.lblGameOver = new System.Windows.Forms.Label();
            this.BTNgamestart = new System.Windows.Forms.Button();
            this.BTNinfo = new System.Windows.Forms.Button();
            this.PBOXstart = new System.Windows.Forms.PictureBox();
            this.pbCanvas = new System.Windows.Forms.PictureBox();
            this.PBGameOver = new System.Windows.Forms.PictureBox();
            this.BTNeasymode = new System.Windows.Forms.Button();
            this.BTNmediummode = new System.Windows.Forms.Button();
            this.BTNhardmode = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.BTNnightmare = new System.Windows.Forms.Button();
            this.BTNmainmenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PBOXstart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGameOver)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Score: ";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(110, 4);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 37);
            this.lblScore.TabIndex = 2;
            // 
            // lblGameOver
            // 
            this.lblGameOver.AutoSize = true;
            this.lblGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(187)))), ((int)(((byte)(14)))));
            this.lblGameOver.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameOver.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblGameOver.Location = new System.Drawing.Point(537, 488);
            this.lblGameOver.Name = "lblGameOver";
            this.lblGameOver.Size = new System.Drawing.Size(102, 37);
            this.lblGameOver.TabIndex = 3;
            this.lblGameOver.Text = "label2";
            this.lblGameOver.Visible = false;
            // 
            // BTNgamestart
            // 
            this.BTNgamestart.Location = new System.Drawing.Point(450, 488);
            this.BTNgamestart.Name = "BTNgamestart";
            this.BTNgamestart.Size = new System.Drawing.Size(75, 23);
            this.BTNgamestart.TabIndex = 4;
            this.BTNgamestart.Text = "Game Start";
            this.BTNgamestart.UseVisualStyleBackColor = true;
            this.BTNgamestart.Click += new System.EventHandler(this.BTNgamestart_Click);
            // 
            // BTNinfo
            // 
            this.BTNinfo.Location = new System.Drawing.Point(424, 524);
            this.BTNinfo.Name = "BTNinfo";
            this.BTNinfo.Size = new System.Drawing.Size(126, 23);
            this.BTNinfo.TabIndex = 6;
            this.BTNinfo.Text = "Instructions";
            this.BTNinfo.UseVisualStyleBackColor = true;
            this.BTNinfo.Click += new System.EventHandler(this.BTNinfo_Click);
            // 
            // PBOXstart
            // 
            this.PBOXstart.Image = global::Snake.Properties.Resources.images;
            this.PBOXstart.Location = new System.Drawing.Point(0, 1);
            this.PBOXstart.Name = "PBOXstart";
            this.PBOXstart.Size = new System.Drawing.Size(995, 556);
            this.PBOXstart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBOXstart.TabIndex = 5;
            this.PBOXstart.TabStop = false;
            // 
            // pbCanvas
            // 
            this.pbCanvas.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.pbCanvas.Image = global::Snake.Properties.Resources.wp2409705;
            this.pbCanvas.Location = new System.Drawing.Point(5, 41);
            this.pbCanvas.Name = "pbCanvas";
            this.pbCanvas.Size = new System.Drawing.Size(990, 516);
            this.pbCanvas.TabIndex = 0;
            this.pbCanvas.TabStop = false;
            this.pbCanvas.Paint += new System.Windows.Forms.PaintEventHandler(this.pbCanvas_Paint);
            // 
            // PBGameOver
            // 
            this.PBGameOver.Image = global::Snake.Properties.Resources.snakegameover;
            this.PBGameOver.Location = new System.Drawing.Point(0, 37);
            this.PBGameOver.Name = "PBGameOver";
            this.PBGameOver.Size = new System.Drawing.Size(995, 520);
            this.PBGameOver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PBGameOver.TabIndex = 7;
            this.PBGameOver.TabStop = false;
            this.PBGameOver.Visible = false;
            this.PBGameOver.Click += new System.EventHandler(this.PBGameOver_Click);
            // 
            // BTNeasymode
            // 
            this.BTNeasymode.Location = new System.Drawing.Point(450, 406);
            this.BTNeasymode.Name = "BTNeasymode";
            this.BTNeasymode.Size = new System.Drawing.Size(75, 23);
            this.BTNeasymode.TabIndex = 9;
            this.BTNeasymode.Text = "easy";
            this.BTNeasymode.UseVisualStyleBackColor = true;
            this.BTNeasymode.Visible = false;
            this.BTNeasymode.Click += new System.EventHandler(this.BTNeasymode_Click);
            // 
            // BTNmediummode
            // 
            this.BTNmediummode.Location = new System.Drawing.Point(450, 448);
            this.BTNmediummode.Name = "BTNmediummode";
            this.BTNmediummode.Size = new System.Drawing.Size(75, 23);
            this.BTNmediummode.TabIndex = 10;
            this.BTNmediummode.Text = "Medium";
            this.BTNmediummode.UseVisualStyleBackColor = true;
            this.BTNmediummode.Visible = false;
            this.BTNmediummode.Click += new System.EventHandler(this.BTNmediummode_Click);
            // 
            // BTNhardmode
            // 
            this.BTNhardmode.Location = new System.Drawing.Point(450, 488);
            this.BTNhardmode.Name = "BTNhardmode";
            this.BTNhardmode.Size = new System.Drawing.Size(75, 23);
            this.BTNhardmode.TabIndex = 11;
            this.BTNhardmode.Text = "Hard";
            this.BTNhardmode.UseVisualStyleBackColor = true;
            this.BTNhardmode.Visible = false;
            this.BTNhardmode.Click += new System.EventHandler(this.BTNhardmode_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(375, 351);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 37);
            this.label2.TabIndex = 12;
            this.label2.Text = "Select difficulty";
            this.label2.Visible = false;
            // 
            // BTNnightmare
            // 
            this.BTNnightmare.Location = new System.Drawing.Point(450, 524);
            this.BTNnightmare.Name = "BTNnightmare";
            this.BTNnightmare.Size = new System.Drawing.Size(75, 23);
            this.BTNnightmare.TabIndex = 13;
            this.BTNnightmare.Text = "Nightmare";
            this.BTNnightmare.UseVisualStyleBackColor = true;
            this.BTNnightmare.Visible = false;
            this.BTNnightmare.Click += new System.EventHandler(this.BTNnightmare_Click);
            // 
            // BTNmainmenu
            // 
            this.BTNmainmenu.Location = new System.Drawing.Point(0, 534);
            this.BTNmainmenu.Name = "BTNmainmenu";
            this.BTNmainmenu.Size = new System.Drawing.Size(995, 23);
            this.BTNmainmenu.TabIndex = 14;
            this.BTNmainmenu.TabStop = false;
            this.BTNmainmenu.Text = "Go back to main menu";
            this.BTNmainmenu.UseVisualStyleBackColor = false;
            this.BTNmainmenu.Visible = false;
            this.BTNmainmenu.Click += new System.EventHandler(this.BTNmainmenu_Click);
            // 
            // FRMsnake
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 559);
            this.Controls.Add(this.BTNmainmenu);
            this.Controls.Add(this.BTNnightmare);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.BTNhardmode);
            this.Controls.Add(this.BTNmediummode);
            this.Controls.Add(this.BTNeasymode);
            this.Controls.Add(this.PBGameOver);
            this.Controls.Add(this.BTNinfo);
            this.Controls.Add(this.BTNgamestart);
            this.Controls.Add(this.PBOXstart);
            this.Controls.Add(this.lblGameOver);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbCanvas);
            this.Name = "FRMsnake";
            this.Text = "Snake Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FRMsnake_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.FRMsnake_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.PBOXstart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbCanvas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBGameOver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pbCanvas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label lblGameOver;
        private System.Windows.Forms.Button BTNgamestart;
        private System.Windows.Forms.PictureBox PBOXstart;
        private System.Windows.Forms.Button BTNinfo;
        private System.Windows.Forms.PictureBox PBGameOver;
        private System.Windows.Forms.Button BTNeasymode;
        private System.Windows.Forms.Button BTNmediummode;
        private System.Windows.Forms.Button BTNhardmode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button BTNnightmare;
        private System.Windows.Forms.Button BTNmainmenu;
    }
}

