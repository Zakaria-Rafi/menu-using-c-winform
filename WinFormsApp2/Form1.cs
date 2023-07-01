using System;
using System.Drawing;
using System.Windows.Forms;
using Timer = System.Windows.Forms.Timer;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        private Timer timer;
        private bool isMenuOpen;
        private int targetHeight;
        private const int TimerInterval = 10;
        private const int AnimationStep = 5;
        private Panel dropdownPanel1;
        private Panel dropdownPanel2;
        private Panel dropdownPanel3;
        private Button dropdownButton3;
        private Button dropdownButton1;
        private Button dropdownButton2;
        private Panel panel1;
        private Button toggleMenuButton;
        private bool isMenuVisible;


        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = TimerInterval;
            timer.Tick += Timer_Tick;
            isMenuOpen = false;
            targetHeight = 0;

            InitializeDropdownPanel();
            InitializeToggleMenuButton();

        }
        private void InitializeToggleMenuButton()
        {
            toggleMenuButton = new Button();
            toggleMenuButton.Text = "▲";
            toggleMenuButton.Size = new Size(40, 40);
            toggleMenuButton.Location = new Point(10, 10);
            toggleMenuButton.FlatStyle = FlatStyle.Flat;
            toggleMenuButton.ForeColor = Color.White;
            toggleMenuButton.BackColor = Color.FromArgb(53, 59, 72);
            toggleMenuButton.FlatAppearance.BorderSize = 0;
            toggleMenuButton.Click += ToggleMenuButton_Click;
            panel3.Controls.Add(toggleMenuButton);
        }
        private void ToggleMenuButton_Click(object sender, EventArgs e)
        {
            if (isMenuVisible)
            {
                panel2.Visible = false;
                panel3.Visible = true;
                panel3.Dock = DockStyle.Fill;
                toggleMenuButton.Text = "▲";
            }
            else
            {
                panel2.Visible = true;
                panel3.Dock = DockStyle.None;
                toggleMenuButton.Text = "▼";
            }

            isMenuVisible = !isMenuVisible;
        }
        private void InitializeDropdownPanel()
        {
            dropdownPanel1 = new Panel();
            dropdownPanel1.BackColor = Color.FromArgb(53, 59, 72);
            dropdownPanel1.Height = 0;
            dropdownPanel1.Visible = false;
            dropdownPanel1.Dock = DockStyle.Top;

            dropdownButton1 = new Button();
            dropdownButton1.Text = "Button 1";
            dropdownButton1.Size = new Size(120, 40);
            dropdownButton1.Location = new Point(10, 10);
            dropdownButton1.FlatStyle = FlatStyle.Flat;
            dropdownButton1.ForeColor = Color.White;
            dropdownButton1.BackColor = Color.FromArgb(46, 204, 113);
            dropdownButton1.FlatAppearance.BorderSize = 0;
            dropdownButton1.Click += DropdownButton1_Click;

            dropdownButton2 = new Button();
            dropdownButton2.Text = "Button 2";
            dropdownButton2.Size = new Size(120, 40);
            dropdownButton2.Location = new Point(140, 10);
            dropdownButton2.FlatStyle = FlatStyle.Flat;
            dropdownButton2.ForeColor = Color.White;
            dropdownButton2.BackColor = Color.FromArgb(52, 152, 219);
            dropdownButton2.FlatAppearance.BorderSize = 0;
            dropdownButton2.Click += DropdownButton2_Click;

            dropdownPanel1.Controls.Add(dropdownButton1);
            dropdownPanel1.Controls.Add(dropdownButton2);
            panel2.Controls.Add(dropdownPanel1);

            // Create and configure the second dropdown panel
            dropdownPanel2 = new Panel();
            dropdownPanel2.BackColor = Color.FromArgb(53, 59, 72);
            dropdownPanel2.Height = 0;
            dropdownPanel2.Visible = false;
            dropdownPanel2.Dock = DockStyle.Top;

            Button dropdownButton3 = new Button();
            dropdownButton3.Text = "Button 3";
            dropdownButton3.Size = new Size(120, 40);
            dropdownButton3.Location = new Point(10, 10);
            dropdownButton3.FlatStyle = FlatStyle.Flat;
            dropdownButton3.ForeColor = Color.White;
            dropdownButton3.BackColor = Color.FromArgb(231, 76, 60);
            dropdownButton3.FlatAppearance.BorderSize = 0;
            dropdownButton3.Click += DropdownButton3_Click;

            Button dropdownButton4 = new Button();
            dropdownButton4.Text = "Button 4";
            dropdownButton4.Size = new Size(120, 40);
            dropdownButton4.Location = new Point(140, 10);
            dropdownButton4.FlatStyle = FlatStyle.Flat;
            dropdownButton4.ForeColor = Color.White;
            dropdownButton4.BackColor = Color.FromArgb(155, 89, 182);
            dropdownButton4.FlatAppearance.BorderSize = 0;
            dropdownButton4.Click += DropdownButton4_Click;

            dropdownPanel2.Controls.Add(dropdownButton3);
            dropdownPanel2.Controls.Add(dropdownButton4);
            panel2.Controls.Add(dropdownPanel2);



            dropdownPanel3 = new Panel();
            dropdownPanel3.BackColor = Color.FromArgb(53, 59, 72);
            dropdownPanel3.Height = 0;
            dropdownPanel3.Visible = false;
            dropdownPanel3.Dock = DockStyle.Top;

            Button dropdownButton5 = new Button();
            dropdownButton5.Text = "Button 5";
            dropdownButton5.Size = new Size(120, 40);
            dropdownButton5.Location = new Point(10, 10);
            dropdownButton5.FlatStyle = FlatStyle.Flat;
            dropdownButton5.ForeColor = Color.White;
            dropdownButton5.BackColor = Color.FromArgb(244, 208, 63);
            dropdownButton5.FlatAppearance.BorderSize = 0;

            Button dropdownButton6 = new Button();
            dropdownButton6.Text = "Button 6";
            dropdownButton6.Size = new Size(120, 40);
            dropdownButton6.Location = new Point(140, 10);
            dropdownButton6.FlatStyle = FlatStyle.Flat;
            dropdownButton6.ForeColor = Color.White;
            dropdownButton6.BackColor = Color.FromArgb(46, 134, 193);
            dropdownButton6.FlatAppearance.BorderSize = 0;

            dropdownPanel3.Controls.Add(dropdownButton5);
            dropdownPanel3.Controls.Add(dropdownButton6);
            panel2.Controls.Add(dropdownPanel3);
        }

        private void DropdownButton1_Click(object sender, EventArgs e)
        {
            // Handle the click event for Button 1 in the first dropdown menu
        }

        private void DropdownButton2_Click(object sender, EventArgs e)
        {
            // Handle the click event for Button 2 in the first dropdown menu
        }

        private void DropdownButton3_Click(object sender, EventArgs e)
        {
            // Handle the click event for Button 3 in the second dropdown menu
        }

        private void DropdownButton4_Click(object sender, EventArgs e)
        {
            // Handle the click event for Button 4 in the second dropdown menu
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                if (dropdownPanel1.Visible)
                {
                    CloseMenu();
                }
                else
                {
                    CloseMenu();
                    OpenMenu(dropdownPanel1);
                }
            }
            else
            {
                OpenMenu(dropdownPanel1);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                if (dropdownPanel2.Visible)
                {
                    CloseMenu();
                }
                else
                {
                    CloseMenu();
                    OpenMenu(dropdownPanel2);
                }
            }
            else
            {
                OpenMenu(dropdownPanel2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (isMenuOpen)
            {
                if (dropdownPanel3.Visible)
                {
                    CloseMenu();
                }
                else
                {
                    CloseMenu();
                    OpenMenu(dropdownPanel3);
                }
            }
            else
            {
                OpenMenu(dropdownPanel3);
            }
        }




        private void OpenMenu(Panel dropdownPanel)
        {
            if (!isMenuOpen)
            {
                isMenuOpen = true;

                // Hide controls in panel2
                foreach (Control control in panel2.Controls)
                {
                    control.Visible = false;
                }

                // Determine the combined height of the open menus
                int totalHeight = dropdownPanel1.PreferredSize.Height + dropdownPanel2.PreferredSize.Height + dropdownPanel3.PreferredSize.Height;

                dropdownPanel.Visible = true;
                dropdownPanel.Size = new Size(panel2.ClientSize.Width, 0);
                targetHeight = totalHeight;

                // Calculate the location of the dropdown panel relative to the main button
                Point mainButtonLocation = button1.PointToScreen(Point.Empty);
                Point dropdownLocation = panel2.PointToClient(mainButtonLocation);
                dropdownPanel.Location = new Point(dropdownLocation.X, dropdownLocation.Y + button1.Height);

                timer.Start();
            }
        }

        private void CloseMenu()
        {
            if (isMenuOpen)
            {
                isMenuOpen = false;
                timer.Start();
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            int currentHeight = dropdownPanel1.Height;
            bool isClosing = !isMenuOpen;

            if (isClosing)
            {
                if (currentHeight <= 0)
                {
                    timer.Stop();
                    dropdownPanel1.Visible = false;
                    dropdownPanel2.Visible = false;
                    dropdownPanel3.Visible = false;
                    RestorePanel2ControlsVisibility();
                }
                else
                {
                    dropdownPanel1.Height = Math.Max(0, currentHeight - AnimationStep);
                    dropdownPanel2.Height = Math.Max(0, currentHeight - AnimationStep);
                    dropdownPanel3.Height = Math.Max(0, currentHeight - AnimationStep);
                }
            }
            else
            {
                if (currentHeight >= targetHeight)
                {
                    timer.Stop();
                    dropdownPanel1.Height = targetHeight;
                    dropdownPanel2.Height = targetHeight;
                    dropdownPanel3.Height = targetHeight;
                }
                else
                {
                    dropdownPanel1.Height = Math.Min(targetHeight, currentHeight + AnimationStep);
                    dropdownPanel2.Height = Math.Min(targetHeight, currentHeight + AnimationStep);
                    dropdownPanel3.Height = Math.Min(targetHeight, currentHeight + AnimationStep);
                }
            }
        }

        private void RestorePanel2ControlsVisibility()
        {
            foreach (Control control in panel2.Controls)
            {
                control.Visible = true;
            }
        }
    }
}

