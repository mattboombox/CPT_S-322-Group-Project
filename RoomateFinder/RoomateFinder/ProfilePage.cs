namespace RoomateFinder
{
    using RoomateFinderEngne;
    using System.Collections.Generic;
    using System.Windows.Forms;
    public partial class ProfilePage : Form
    {
        private RoomateFinderController controller;

        public ProfilePage(RoomateFinderController controller)
        {
            this.controller = controller;

            InitializeComponent();
            LoadUserProfile();
        }

        private void LoadUserProfile()
        {
            // Assuming you have a method to get the active user
            var user = controller.GetActiveUser();

            // Display user information in labels or textboxes
            name.Text = user.Username;
            bio.Text = user.Bio;
            // lastNameLabel.Text = user.LastName;
            // Add other user details as needed
        }

        private void bioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bio.Visible = false; // Hide the label
            bioEditor.Text = bio.Text;
            bioEditor.Visible = true; // Show the TextBox
            bioEditor.Focus(); // Set focus to the TextBox to start editing

            bioEditor.KeyDown += new KeyEventHandler(BioEditor_Enter); // Add event handler to save on Enter
        }

        private void BioEditor_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {              
                bio.Text = bioEditor.Text; // Update the label with the edited text
                bio.Visible = true; // Show the label again
                bioEditor.Visible = false; // Hide the TextBox

                var user = controller.GetActiveUser();
                user.Bio = bioEditor.Text; // Update the bio in the user profile

                e.Handled = true;
                e.SuppressKeyPress = true;

                bio.KeyDown -= new KeyEventHandler(BioEditor_Enter);
            }
        }
    }
}
