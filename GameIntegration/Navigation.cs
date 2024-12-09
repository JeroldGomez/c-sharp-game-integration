using System;
using System.Drawing;
using System.Windows.Forms;
using Space_battle_shooter_WPF_MOO_ICT;
using Side_Scrolling_Game_MOO_ICT;
using Shoot_Out_Game_MOO_ICT;
using Flappy_Bird_Windows_Form;
using Save_the_Eggs_Game_MOO_ICT;
using T_Rex_Endless_Runner_MOO_ICT;
using FontAwesome.Sharp;
using System.Windows.Media;
using System.Collections.Generic;

namespace GameIntegration
{
    public partial class Navigation : Form
    {
        private IconButton currentBtn;
        private Panel leftBorderBtn;

        // Store the selected game type
        private Type selectedGameType;

        private Dictionary<Type, string> gameScreenshots;



        public Navigation()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(7, 60);
            panelMenu.Controls.Add(leftBorderBtn);

            this.Text = string.Empty;

            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;

            // Initialize screenshot paths
            gameScreenshots = new Dictionary<Type, string>
            {
                { typeof(TRexForm), "screenshots/trex.png" },
                { typeof(SlidingGame), "screenshots/side.png" },
                { typeof(ZombieGameForm), "screenshots/zombie.png" },
                { typeof(FlappyBirdForm), "screenshots/bird.png" },
                { typeof(EggGameForm), "screenshots/egg.png" }
            };

            // Add a PictureBox to panelDesktop
            PictureBox screenshotBox = new PictureBox
            {
                Name = "screenshotBox",
                Dock = DockStyle.Fill,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Visible = false // Initially hidden
            };
            panelDesktop.Controls.Add(screenshotBox);
        }

        private struct RGBColors
        {
            public static System.Drawing.Color color1 = System.Drawing.Color.FromArgb(172, 126, 241);
            public static System.Drawing.Color color2 = System.Drawing.Color.FromArgb(249, 118, 176);
            public static System.Drawing.Color color3 = System.Drawing.Color.FromArgb(253, 138, 114);
            public static System.Drawing.Color color4 = System.Drawing.Color.FromArgb(95, 77, 221);
            public static System.Drawing.Color color5 = System.Drawing.Color.FromArgb(249, 88, 155);
            public static System.Drawing.Color color6 = System.Drawing.Color.FromArgb(87, 204, 153);
        }

        private void ShowScreenshot(Type gameType)
        {
            PictureBox screenshotBox = panelDesktop.Controls["screenshotBox"] as PictureBox;

            if (screenshotBox != null && gameScreenshots.ContainsKey(gameType))
            {
                screenshotBox.Image = Image.FromFile(gameScreenshots[gameType]);
                screenshotBox.Visible = true;
            }
        }

        private void ActivateButton(object senderBtn, System.Drawing.Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();

                // Buttons when Clicked
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = System.Drawing.Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                // Left border Button
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = true;
                leftBorderBtn.BringToFront();
                leftBorderBtn.Height = 50;

                // Icon Current Child Form
                iconCurrentChildForm.IconChar = currentBtn.IconChar;
                iconCurrentChildForm.IconColor = color;
                lblTitleChildForm.Text = currentBtn.Text;
            }
        }

        private void DisableButton()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = System.Drawing.Color.FromArgb(0, 19, 45);
                currentBtn.ForeColor = System.Drawing.Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = System.Drawing.Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void game1Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color1);
            selectedGameType = typeof(TRexForm); // Store the type of the selected game
            ShowScreenshot(selectedGameType);

        }

        private void game2Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color2);
            selectedGameType = typeof(SlidingGame); // Store the type of the selected game
            ShowScreenshot(selectedGameType);
        }

        private void game3Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color3);
            selectedGameType = typeof(ZombieGameForm); // Store the type of the selected game
            ShowScreenshot(selectedGameType);
        }

        private void game4Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color4);
            selectedGameType = typeof(FlappyBirdForm); // Store the type of the selected game
            ShowScreenshot(selectedGameType);
        }

        private void game5Btn_Click(object sender, EventArgs e)
        {
            ActivateButton(sender, RGBColors.color5);
            selectedGameType = typeof(EggGameForm); // Store the type of the selected game
            ShowScreenshot(selectedGameType);
        }

        private void homeBtn_Click(object sender, EventArgs e)
        {
            DisableButton();
            leftBorderBtn.Visible = false;
            selectedGameType = null; // Reset selected game type

            // Hide the screenshot
            PictureBox screenshotBox = panelDesktop.Controls["screenshotBox"] as PictureBox;
            if (screenshotBox != null)
            {
                screenshotBox.Visible = false;
            }


            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(65, 105, 225);
            lblTitleChildForm.Text = "Home";
        }

        private void playBtn_Click(object sender, EventArgs e)
        {
            if (selectedGameType != null)
            {
                ActivateButton(sender, RGBColors.color6);

                // Create and show the selected game form dynamically
                Form gameForm = (Form)Activator.CreateInstance(selectedGameType);

                gameForm.FormClosed += (s, args) =>
                {
                    this.WindowState = FormWindowState.Normal; // Restore Navigation form
                    this.Show();
                };

                this.Hide(); // Hide the Navigation form
                gameForm.Show();
            }
            else
            {
                MessageBox.Show("Please select a game first!", "No Game Selected", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

       
    }
}
