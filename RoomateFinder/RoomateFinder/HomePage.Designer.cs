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
            // Initialize components
            components = new System.ComponentModel.Container();

            // Set Form properties
            this.Text = "RoomMate Finder - Home";
            this.Size = new Size(1024, 768); // Increased form size
            this.MinimumSize = new Size(2000, 1000);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.White;

            // Main Layout Panel
            mainLayout = new TableLayoutPanel();
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.RowCount = 2;
            mainLayout.ColumnCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F)); // Increased navigation bar height
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); 
            this.Controls.Add(mainLayout);

            // Navigation Bar Panel
            navBar = new Panel();
            navBar.Dock = DockStyle.Fill;
            navBar.BackColor = Color.FromArgb(30, 144, 255); 
            navBar.Padding = new Padding(20, 10, 20, 10); 

            // Title Label
            titleLabel = new Label();
            titleLabel.Text = "RoomMate Finder";
            titleLabel.Font = new Font("Segoe UI", 28, FontStyle.Bold); 
            titleLabel.ForeColor = Color.White;
            titleLabel.AutoSize = true;
            titleLabel.Dock = DockStyle.Left;

            // Navigation Buttons
            InitializeNavButtons();

            // Add controls to navBar
            navBar.Controls.Add(navButtonsPanel);
            navBar.Controls.Add(titleLabel);

            // Content Panel
            contentPanel = new Panel();
            contentPanel.Dock = DockStyle.Fill;
            contentPanel.Padding = new Padding(40); // Increased padding
            contentPanel.BackColor = Color.White;

            // Matches Label
            matchesLabel = new Label();
            matchesLabel.Text = "Available Matches";
            matchesLabel.Font = new Font("Segoe UI", 24, FontStyle.Bold); // Increased font size
            matchesLabel.ForeColor = Color.Black;
            matchesLabel.AutoSize = true;
            matchesLabel.Dock = DockStyle.Top;
            matchesLabel.Margin = new Padding(0, 0, 0, 20); // Added margin below label

            // Matches ListBox
            matchesListBox = new ListBox();
            matchesListBox.Font = new Font("Segoe UI", 16); // Increased font size
            matchesListBox.Dock = DockStyle.Fill;
            matchesListBox.Margin = new Padding(0, 0, 0, 0);
            matchesListBox.DoubleClick += MatchesListBox_Click;

            // Add controls to contentPanel
            contentPanel.Controls.Add(matchesListBox);
            contentPanel.Controls.Add(matchesLabel);

            // Add panels to mainLayout
            mainLayout.Controls.Add(navBar, 0, 0);
            mainLayout.Controls.Add(contentPanel, 0, 1);

            // Adjust control order to ensure titleLabel is in front
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