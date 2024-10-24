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

    }
}
