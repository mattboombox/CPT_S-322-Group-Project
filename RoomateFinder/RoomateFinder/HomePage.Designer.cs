namespace RoomateFinder
{
    partial class HomePage
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
            // Suspend layout for performance
            SuspendLayout();

            // Profile Button
            Button profileButton = new Button();
            profileButton.Text = "Profile";
            profileButton.Location = new Point(700, 0);  // Adjust the position as necessary
            profileButton.Size = new Size(100, 30);
            profileButton.Click += ProfileButton_Click;  // Event handler for profile button click
            profileButton.FlatStyle = FlatStyle.Flat;
            profileButton.BackColor = Color.SteelBlue;
            profileButton.ForeColor = Color.White;
            this.Controls.Add(profileButton);

            // Logout Button
            Button logoutButton = new Button();
            logoutButton.Text = "Logout";
            logoutButton.Location = new Point(700, 30);  // Adjust the position as necessary
            logoutButton.Size = new Size(100, 30);
            logoutButton.Click += LogoutButton_Click;  // Event handler for logout button click
            logoutButton.FlatStyle = FlatStyle.Flat;
            logoutButton.BackColor = Color.SteelBlue;
            logoutButton.ForeColor = Color.White;
            this.Controls.Add(logoutButton);

            // Matches Label
            Label matchesLabel = new Label();
            matchesLabel.Text = "Available Matches:";
            matchesLabel.Font = new Font("Arial", 14, FontStyle.Bold);
            matchesLabel.Location = new Point(50, 100); 
            matchesLabel.AutoSize = true;
            matchesLabel.FlatStyle = FlatStyle.Flat;
            matchesLabel.BackColor = Color.Gray;
            matchesLabel.ForeColor = Color.White;
            this.Controls.Add(matchesLabel);


            // Settings Button 
            Button settingsButton = new Button();
            settingsButton.Text = "Settings";
            settingsButton.Location = new Point(700, 60);  // Adjust the position as necessary
            settingsButton.Size = new Size(100, 30);
            settingsButton.Click += SettingsButton_Click;  // Event handler for preferences button click
            settingsButton.FlatStyle = FlatStyle.Flat;
            settingsButton.BackColor = Color.SteelBlue;
            settingsButton.ForeColor = Color.White;

            this.Controls.Add(settingsButton);
    
            // Home Page Form Properties
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            this.BackColor = Color.WhiteSmoke;
            Name = "HomePage";
            Text = "RoomMate Finder Homepage";
            Load += HomePage_Load;

            ResumeLayout(false);
    }
        private void ProfileButton_Click(object sender, EventArgs e)
        {
            ProfilePage profilePage = new ProfilePage(controller);
            profilePage.Show(); 
        }

        // Event handler for the Logout button click
        private void LogoutButton_Click(object sender, EventArgs e)
        {
            // Close the home page and return to the login page
            this.Close();
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
        }

        // Event handler for the Preferences button click
        private void SettingsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Settings will be implemented here.", "Settings", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }



        
     
    }

    #endregion
}
