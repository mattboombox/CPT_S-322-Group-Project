namespace RoomateFinder
{
    using Microsoft.AspNetCore.Http;
    using System.IO;
    using Microsoft.Extensions.Options;
    using RoomateFinderEngne;
    using RoomateFinder.Services;

    public partial class ProfilePage : Form
    {
        private RoomateFinderController controller;
        private PictureBox profilePictureBox;
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

            if (!string.IsNullOrEmpty(user.ProfilePhotoUrl))
            {
                profilePictureBox.ImageLocation = user.ProfilePhotoUrl;
            }
        }
        private void bioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bio.Visible = false; // Hide the label
            bioEditor.Text = bio.Text;
            bioEditor.Visible = true; // Show the TextBox
            bioEditor.Focus(); // Set focus to the TextBox to start editing
            bioEditor.KeyDown += new KeyEventHandler(BioEditor_Enter); // Add event handler to save on Enter
        }
        private void usernameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            name.Visible = false; 
            name.Text = name.Text;
            nameEditor.Visible = true; 
            nameEditor.Focus(); 
            nameEditor.KeyDown += new KeyEventHandler(NameEditor_Enter); 
        }



        private void NameEditor_Enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {              
                name.Text = nameEditor.Text; // Update the label with the edited text
                name.Visible = true; // Show the label again
                nameEditor.Visible = false; // Hide the TextBox

                var user = controller.GetActiveUser();
                user.Username = nameEditor.Text; // Update the bio in the user profile

                ProfileManager profileManager = new ProfileManager();
                profileManager.UpdateUserProfile(user.Username, user.Bio);

                e.Handled = true;
                e.SuppressKeyPress = true;

                nameEditor.KeyDown -= new KeyEventHandler(NameEditor_Enter);
            }
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

                ProfileManager profileManager = new ProfileManager();
                profileManager.UpdateUserProfile(user.Username, user.Bio);

                e.Handled = true;
                e.SuppressKeyPress = true;

                bio.KeyDown -= new KeyEventHandler(BioEditor_Enter);
            }
        }

        public void UpdateUserProfile(string username, string bio, string profilePhotoUrl = null)
        {
            var user = ProfileManager.GetUserByUsername(username);
            if (user != null)
            {
                user.Bio = bio;
                if (!string.IsNullOrEmpty(profilePhotoUrl))
                {
                    user.ProfilePhotoUrl = profilePhotoUrl;
                }
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
                    var file = new Microsoft.AspNetCore.Http.Internal.FormFile(fileStream, 0, fileStream.Length, null, Path.GetFileName(fileStream.Name))
                    {
                        Headers = new HeaderDictionary(),
                        ContentType = "image/jpeg"
                    };

                    // Upload the file using PhotoService
                    var photoService = new PhotoService(new OptionsWrapper<CloudinarySettings>(new CloudinarySettings
                    {
                        //cloudinary settings
                        CloudName = "dcrfchrlr",
                        ApiKey = "475369936414641",
                        ApiSecret = "DOMV6YbYq3MfwxpdYjxudpg15AE"
                    }));
                    var uploadResult = await photoService.AddPhotoAsync(file);

                    if (uploadResult != null)
                    {
                        var user = controller.GetActiveUser();
                        user.ProfilePhotoUrl = uploadResult.SecureUrl.ToString();

                            // Display the uploaded photo
                        PictureBox profilePictureBox = this.Controls["profilePictureBox"] as PictureBox;
                        if (profilePictureBox != null)
                        {
                            profilePictureBox.ImageLocation = user.ProfilePhotoUrl;
                        }
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

