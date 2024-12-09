namespace GameIntegration
{
    partial class Navigation
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.playBtn = new FontAwesome.Sharp.IconButton();
            this.game5Btn = new FontAwesome.Sharp.IconButton();
            this.game4Btn = new FontAwesome.Sharp.IconButton();
            this.game3Btn = new FontAwesome.Sharp.IconButton();
            this.game2Btn = new FontAwesome.Sharp.IconButton();
            this.game1Btn = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.screenshotBox = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.panelDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(30)))), ((int)(((byte)(69)))));
            this.panelMenu.Controls.Add(this.playBtn);
            this.panelMenu.Controls.Add(this.game5Btn);
            this.panelMenu.Controls.Add(this.game4Btn);
            this.panelMenu.Controls.Add(this.game3Btn);
            this.panelMenu.Controls.Add(this.game2Btn);
            this.panelMenu.Controls.Add(this.game1Btn);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(192, 450);
            this.panelMenu.TabIndex = 5;
            // 
            // playBtn
            // 
            this.playBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.playBtn.FlatAppearance.BorderSize = 0;
            this.playBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.playBtn.IconChar = FontAwesome.Sharp.IconChar.Play;
            this.playBtn.IconColor = System.Drawing.Color.White;
            this.playBtn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.playBtn.IconSize = 30;
            this.playBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.playBtn.Location = new System.Drawing.Point(0, 400);
            this.playBtn.Name = "playBtn";
            this.playBtn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.playBtn.Size = new System.Drawing.Size(192, 50);
            this.playBtn.TabIndex = 6;
            this.playBtn.Text = "PLAY";
            this.playBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.playBtn.UseVisualStyleBackColor = true;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // game5Btn
            // 
            this.game5Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.game5Btn.FlatAppearance.BorderSize = 0;
            this.game5Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game5Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.game5Btn.IconChar = FontAwesome.Sharp.IconChar.Egg;
            this.game5Btn.IconColor = System.Drawing.Color.White;
            this.game5Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.game5Btn.IconSize = 30;
            this.game5Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.game5Btn.Location = new System.Drawing.Point(0, 289);
            this.game5Btn.Name = "game5Btn";
            this.game5Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.game5Btn.Size = new System.Drawing.Size(192, 50);
            this.game5Btn.TabIndex = 5;
            this.game5Btn.Text = "Save the Eggs";
            this.game5Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.game5Btn.UseVisualStyleBackColor = true;
            this.game5Btn.Click += new System.EventHandler(this.game5Btn_Click);
            // 
            // game4Btn
            // 
            this.game4Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.game4Btn.FlatAppearance.BorderSize = 0;
            this.game4Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game4Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.game4Btn.IconChar = FontAwesome.Sharp.IconChar.Dove;
            this.game4Btn.IconColor = System.Drawing.Color.White;
            this.game4Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.game4Btn.IconSize = 30;
            this.game4Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.game4Btn.Location = new System.Drawing.Point(0, 239);
            this.game4Btn.Name = "game4Btn";
            this.game4Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.game4Btn.Size = new System.Drawing.Size(192, 50);
            this.game4Btn.TabIndex = 4;
            this.game4Btn.Text = "Flappy Bird";
            this.game4Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.game4Btn.UseVisualStyleBackColor = true;
            this.game4Btn.Click += new System.EventHandler(this.game4Btn_Click);
            // 
            // game3Btn
            // 
            this.game3Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.game3Btn.FlatAppearance.BorderSize = 0;
            this.game3Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game3Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.game3Btn.IconChar = FontAwesome.Sharp.IconChar.Biohazard;
            this.game3Btn.IconColor = System.Drawing.Color.White;
            this.game3Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.game3Btn.IconSize = 30;
            this.game3Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.game3Btn.Location = new System.Drawing.Point(0, 189);
            this.game3Btn.Name = "game3Btn";
            this.game3Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.game3Btn.Size = new System.Drawing.Size(192, 50);
            this.game3Btn.TabIndex = 3;
            this.game3Btn.Text = "Zombie Shoot Out";
            this.game3Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.game3Btn.UseVisualStyleBackColor = true;
            this.game3Btn.Click += new System.EventHandler(this.game3Btn_Click);
            // 
            // game2Btn
            // 
            this.game2Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.game2Btn.FlatAppearance.BorderSize = 0;
            this.game2Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game2Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.game2Btn.IconChar = FontAwesome.Sharp.IconChar.Running;
            this.game2Btn.IconColor = System.Drawing.Color.White;
            this.game2Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.game2Btn.IconSize = 30;
            this.game2Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.game2Btn.Location = new System.Drawing.Point(0, 139);
            this.game2Btn.Name = "game2Btn";
            this.game2Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.game2Btn.Size = new System.Drawing.Size(192, 50);
            this.game2Btn.TabIndex = 2;
            this.game2Btn.Text = "Side Scrolling";
            this.game2Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.game2Btn.UseVisualStyleBackColor = true;
            this.game2Btn.Click += new System.EventHandler(this.game2Btn_Click);
            // 
            // game1Btn
            // 
            this.game1Btn.Dock = System.Windows.Forms.DockStyle.Top;
            this.game1Btn.FlatAppearance.BorderSize = 0;
            this.game1Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.game1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.game1Btn.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.game1Btn.IconChar = FontAwesome.Sharp.IconChar.Dragon;
            this.game1Btn.IconColor = System.Drawing.Color.White;
            this.game1Btn.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.game1Btn.IconSize = 30;
            this.game1Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.game1Btn.Location = new System.Drawing.Point(0, 89);
            this.game1Btn.Name = "game1Btn";
            this.game1Btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.game1Btn.Size = new System.Drawing.Size(192, 50);
            this.game1Btn.TabIndex = 1;
            this.game1Btn.Text = "T-Rex Endless Runner";
            this.game1Btn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.game1Btn.UseVisualStyleBackColor = true;
            this.game1Btn.Click += new System.EventHandler(this.game1Btn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.homeBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(192, 89);
            this.panel1.TabIndex = 0;
            // 
            // homeBtn
            // 
            this.homeBtn.Image = global::GameIntegration.Properties.Resources.Logo_C;
            this.homeBtn.Location = new System.Drawing.Point(36, 22);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(112, 50);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(59)))));
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.iconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(192, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(608, 72);
            this.panelTitleBar.TabIndex = 6;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblTitleChildForm.Location = new System.Drawing.Point(55, 32);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(35, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "Home";
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(25)))), ((int)(((byte)(59)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.House;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(17, 22);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(19)))), ((int)(((byte)(45)))));
            this.panelDesktop.Controls.Add(this.screenshotBox);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(192, 72);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(608, 378);
            this.panelDesktop.TabIndex = 7;
            // 
            // screenshotBox
            // 
            this.screenshotBox.Location = new System.Drawing.Point(39, 17);
            this.screenshotBox.Name = "screenshotBox";
            this.screenshotBox.Size = new System.Drawing.Size(541, 332);
            this.screenshotBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.screenshotBox.TabIndex = 0;
            this.screenshotBox.TabStop = false;
            // 
            // Navigation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Navigation";
            this.Text = "Navigation";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.screenshotBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton game1Btn;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton game5Btn;
        private FontAwesome.Sharp.IconButton game4Btn;
        private FontAwesome.Sharp.IconButton game3Btn;
        private FontAwesome.Sharp.IconButton game2Btn;
        private System.Windows.Forms.PictureBox homeBtn;
        private FontAwesome.Sharp.IconButton playBtn;
        private System.Windows.Forms.Panel panelTitleBar;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel panelDesktop;
        private System.Windows.Forms.PictureBox screenshotBox;
    }
}

