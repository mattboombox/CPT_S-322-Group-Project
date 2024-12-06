using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Options;
using RoomateFinder.Services;
using RoomateFinderEngne;

namespace RoomateFinder
{
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
    var user = controller.GetActiveUser();

    // Display user information
    name.Text = user.Username;
    bio.Text = user.Bio;

    if (!string.IsNullOrEmpty(user.ProfilePhotoUrl))
    {
        profilePictureBox.ImageLocation = user.ProfilePhotoUrl;
    }
}
        private void bioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bio.Visible = false;
            bioEditor.Text = bio.Text;
            bioEditor.Visible = true;
            bioEditor.Focus();
            bioEditor.KeyDown += BioTextBox_KeyDown;    
        }

        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.Visible = false;
            nameEditor.Text = name.Text;
            nameEditor.Visible = true;
            nameEditor.Focus();
            nameEditor.KeyDown += NameTextBox_KeyDown;
        }

        private void NameTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                name.Text = nameEditor.Text; // Update the label with the edited text
                name.Visible = true; // Show the label again
                nameEditor.Visible = false; // Hide the TextBox

                var user = controller.GetActiveUser();
                user.Username = nameEditor.Text; // Update the username in the user profile

                // Update the profile
                ProfileManager profileManager = new ProfileManager();
                profileManager.UpdateUserProfile(user.Username, user.Bio);

                e.Handled = true;
                e.SuppressKeyPress = true;

                nameEditor.KeyDown -= NameTextBox_KeyDown;
            }
        }

        private void BioTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                bio.Text = bioEditor.Text; // Update the label with the edited text
                bio.Visible = true; // Show the label again
                bioEditor.Visible = false; // Hide the TextBox

                var user = controller.GetActiveUser();
                user.Bio = bioEditor.Text; // Update the bio in the user profile

                // Update the profile
                ProfileManager profileManager = new ProfileManager();
                profileManager.UpdateUserProfile(user.Username, user.Bio);

                e.Handled = true;
                e.SuppressKeyPress = true;

                bioEditor.KeyDown -= BioTextBox_KeyDown;
            }
        }

        private async void UploadPhotoButton_Click(object sender, EventArgs e)
        {
            using OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog.FileName;

                try
                {
                    // Convert the file to an IFormFile
                    var fileStream = new FileStream(filePath, FileMode.Open);
                    var formFile = new Microsoft.AspNetCore.Http.Internal.FormFile(fileStream, 0, fileStream.Length, null, Path.GetFileName(fileStream.Name))
                    {
                        Headers = new HeaderDictionary(),
                        ContentType = "image/jpeg"
                    };

                    // Upload the file using PhotoService
                    var photoService = new PhotoService(new OptionsWrapper<CloudinarySettings>(new CloudinarySettings
                    {
                        CloudName = "dcrfchrlr",
                        ApiKey = "475369936414641",
                        ApiSecret = "DOMV6YbYq3MfwxpdYjxudpg15AE"
                    }));
                    var uploadResult = await photoService.AddPhotoAsync(formFile);

                    if (uploadResult != null)
                    {
                        var user = controller.GetActiveUser();
                        user.ProfilePhotoUrl = uploadResult.SecureUrl.ToString();

                        // Display the uploaded photo
                        profilePictureBox.ImageLocation = user.ProfilePhotoUrl;

                        // Save the profile photo URL
                        ProfileManager profileManager = new ProfileManager();
                        profileManager.UpdateUserProfile(user.Username, user.Bio, user.ProfilePhotoUrl);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}