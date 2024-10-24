//Information like a users name, email, phone number, and a short bio will be displayed on the profile page.
namespace RoomateFinder
{
    partial class ProfilePage{
        private Label name;
        private Label bio;

        private void InitializeComponent()
        {
            name = new Label();
            bio = new Label();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(50, 50);
            name.Name = "name";
            name.Size = new Size(50, 30);
            name.TabIndex = 0;
            // 
            // bio
            // 
            bio.Location = new Point(200, 50);
            bio.Name = "bio";
            bio.Size = new Size(50, 30);
            bio.TabIndex = 0;
            // 
            // ProfilePage
            // 
            ClientSize = new Size(800, 450);
            Controls.Add(name);
            Controls.Add(bio);
            Name = "ProfilePage";
            Text = "Profile Page";
            ResumeLayout(false);
        }
    }
}
