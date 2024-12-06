namespace RoomateFinder
{
    using System.ComponentModel;
    using RoomateFinderEngne;

    public partial class LoginForm : Form
    {
        private RoomateFinderController controller;

        public LoginForm()
        {
            this.InitializeComponent();
            this.controller = new RoomateFinderController();
            this.label3.Text = string.Empty;

            // Properly wire the TextChanged events
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = usernameTextBox.Text.Trim();
            string password = passwordTextBox.Text.Trim();

            if (this.controller.newLogin.ValidateUserInfo())
            {
                this.controller.SetActiveUser(username);
                Console.WriteLine($"Active user set: {username}");

                // Load matches for the active user
                MatchManager matchManager = new MatchManager(this.controller);
                matchManager.FindMatches();

                this.Hide();
                var homePage = new HomePage(this.controller);
                homePage.ShowDialog();
                this.Close();
            }
            else
            {
                this.label3.Text = "Incorrect Username/Password";
                this.label3.ForeColor = Color.Red;
                this.label3.Visible = true;
            }
        }

        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            this.controller.newLogin.Username = usernameTextBox.Text;
        }

        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            this.controller.newLogin.Password = passwordTextBox.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.controller.newLogin.CreateNewUser();
            MessageBox.Show("New user created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
