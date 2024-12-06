using System.Xml.Serialization;
using RoomateFinderEngne;
namespace RoomateFinder
{
    partial class HomePage
    {
    
        private System.ComponentModel.IContainer components = null;
        private Button profileButton;
        private Button logoutButton;
        private Button surveyButton;
        private Label matchesLabel;
        private TableLayoutPanel mainLayout;
        private Panel navBar;
        private Panel contentPanel;
        private Label titleLabel;

 
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code


        private void InitializeComponent()
        {
            this.AutoScaleMode = AutoScaleMode.Dpi;
            this.AutoScaleDimensions = new SizeF(96F, 96F);

            components = new System.ComponentModel.Container();

            this.Text = "RoomMate Finder - Home";
            this.Size = new Size(1280, 768);
            this.MinimumSize = new Size(800, 600); 
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            mainLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                RowCount = 2,
                ColumnCount = 1
            };
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F)); // Navigation bar height
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); // Remaining space for content
            this.Controls.Add(mainLayout);

            navBar = new Panel
            {
                Dock = DockStyle.Fill,
                BackColor = Color.FromArgb(30, 144, 255),
                Padding = new Padding(20, 10, 20, 10) // Adjust padding
            };

            titleLabel = new Label
            {
                Text = "RoomMate Finder",
                Font = new Font("Segoe UI", 28, FontStyle.Bold),
                ForeColor = Color.White,
                AutoSize = true,
                Dock = DockStyle.Left
            };

            InitializeNavButtons();

            navBar.Controls.Add(navButtonsPanel);
            navBar.Controls.Add(titleLabel);

            contentPanel = new Panel
            {
                Dock = DockStyle.Fill,
                Padding = new Padding(40), 
                BackColor = Color.White
            };

            matchesLabel = new Label
            {
                Text = "Available Matches",
                Font = new Font("Segoe UI", 24, FontStyle.Bold),
                ForeColor = Color.Black,
                AutoSize = true,
                Dock = DockStyle.Top,
                Margin = new Padding(0, 0, 0, 20) // Space below the label
            };

            matchesListBox = new ListBox
            {
                Font = new Font("Segoe UI", 16),
                Dock = DockStyle.Fill,
                Margin = new Padding(0, 0, 0, 0)
            };
            matchesListBox.DoubleClick += MatchesListBox_Click;

            contentPanel.Controls.Add(matchesListBox);
            contentPanel.Controls.Add(matchesLabel);

            mainLayout.Controls.Add(navBar, 0, 0);
            mainLayout.Controls.Add(contentPanel, 0, 1);

            navBar.Controls.SetChildIndex(titleLabel, 1);
        }

        private FlowLayoutPanel navButtonsPanel;

        private void InitializeNavButtons()
        {
            // Profile Button
            profileButton = new Button();
            profileButton.Text = "Profile";
            profileButton.Size = new Size(140, 60); // Adjusted size
            profileButton.Click += ProfileButton_Click;
            StyleNavButton(profileButton);

            // Logout Button
            logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Size = new Size(140, 60); // Adjusted size
            logoutButton.Click += LogoutButton_Click;
            StyleNavButton(logoutButton);

            // Survey Button
            surveyButton = new Button();
            surveyButton.Text = "Survey";
            surveyButton.Size = new Size(140, 60); // Adjust the size as needed
            surveyButton.Click += SurveyButton_Click;
            StyleNavButton(surveyButton);

            // Add buttons to navigation bar
            navButtonsPanel = new FlowLayoutPanel();
            navButtonsPanel.Dock = DockStyle.Right;
            navButtonsPanel.AutoSize = true;
            navButtonsPanel.FlowDirection = FlowDirection.LeftToRight;
            navButtonsPanel.WrapContents = false;
            navButtonsPanel.Padding = new Padding(0);
            navButtonsPanel.Margin = new Padding(0);

            navButtonsPanel.Controls.Add(surveyButton);
            navButtonsPanel.Controls.Add(profileButton);
            navButtonsPanel.Controls.Add(logoutButton);
        }

        private void StyleNavButton(Button button)
        {
            button.FlatStyle = FlatStyle.Flat;
            button.FlatAppearance.BorderSize = 0;
            button.BackColor = Color.FromArgb(65, 105, 225); 
            button.ForeColor = Color.White;
            button.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            button.Margin = new Padding(10, 0, 0, 0);
            button.Cursor = Cursors.Hand;
            button.MouseEnter += (s, e) => button.BackColor = Color.FromArgb(30, 144, 255);
            button.MouseLeave += (s, e) => button.BackColor = Color.FromArgb(65, 105, 225);
        }

        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(controller);
            profilePage.Show();
        }

        private void LogoutButton_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }
        private void SurveyButton_Click(object sender, EventArgs e)
        {
            SurveyUI surveyForm = new SurveyUI();
            surveyForm.Show();
        }

 
    }

    #endregion
}