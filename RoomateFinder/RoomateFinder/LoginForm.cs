namespace RoomateFinder
{
    using System.ComponentModel;
    using RoomateFinderEngne;

    public partial class LoginForm : Form
    {
        /// <summary>
        /// the main controller for the program.
        /// </summary>
        private RoomateFinderController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoginForm"/> class.
        /// Form that displays the Login screen.
        /// </summary>
        public LoginForm()
        {
            this.InitializeComponent();

            this.controller = new RoomateFinderController();
            this.label3.Text = string.Empty;
        }

        /// currently unused but don't delete.
        private void LoginForm_Load(object sender, EventArgs e)
        { }

        /// <summary>
        /// login button event handler.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (this.controller.newLogin.ValidateUserInfo())
            {
                this.label3.Text = "Logging in...";

                this.controller.SetActiveUser(this.controller.newLogin.Username);
                this.Hide(); // Hides the login form
                MatchManager matchManager = new MatchManager(this.controller);
                matchManager.findMatches();
                HomePage homepage = new HomePage(this.controller); // shows the homepage form.
                homepage.ShowDialog();
                this.Close();
            }
            else
            {
                this.label3.Text = "Incorrect Username/Password";
            }
        }

        /// <summary>
        /// sets the username in the controller to what was entered into the form.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void usernameTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.controller.newLogin.Username != this.usernameTextBox.Text)
            {
                this.controller.newLogin.Username = this.usernameTextBox.Text;
            }
        }

        /// <summary>
        /// sets the password in the controller to what was entered into the form.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void passwordTextBox_TextChanged(object sender, EventArgs e)
        {
            if (this.controller.newLogin.Password != this.passwordTextBox.Text)
            {
                this.controller.newLogin.Password = this.passwordTextBox.Text;
            }
        }

        /// <summary>
        /// Create new profile button handler.
        /// </summary>
        /// <param name="sender">sender.</param>
        /// <param name="e">e.</param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.controller.newLogin.CreateNewUser();
            

        }
    }
}
