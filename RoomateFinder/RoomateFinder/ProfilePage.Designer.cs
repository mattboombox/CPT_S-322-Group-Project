//Information like a users name, email, phone number, and a short bio will be displayed on the profile page.
namespace RoomateFinder
{
    partial class ProfilePage{
        private Label name;

        private void InitializeComponent()
        {
            this.name = new Label();

            // First Name Label
            this.name.Location = new Point(50, 50);
            this.name.Size = new Size(200, 30);
            this.Controls.Add(this.name);

        
            // Form Properties
            this.Text = "Profile Page";
            this.ClientSize = new Size(800, 450);
        }
    }
}
