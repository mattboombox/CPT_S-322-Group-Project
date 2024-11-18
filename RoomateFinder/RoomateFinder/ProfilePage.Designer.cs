//Information like a users name, email, phone number, and a short bio will be displayed on the profile page.
namespace RoomateFinder
{
    partial class ProfilePage{
        private Label name;
        private Label bio;
        private TextBox nameEditor;
        private TextBox bioEditor;
        private void InitializeComponent()
        {
            name = new Label();
            nameEditor = new TextBox();
            bio = new Label();
            bioEditor = new TextBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            usernameToolStripMenuItem = new ToolStripMenuItem();
            bioToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(850, 400);
            name.Name = "name";
            name.Font = new Font("Arial", 30, FontStyle.Bold);
            name.Size = new Size(500, 74);
            name.TabIndex = 0;
            name.AutoSize = false;
            name.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // bio
            // 
            bio.Location = new Point(500, 500);
            bio.Name = "bio";
            bio.Size = new Size(1000, 300);
            bio.BorderStyle = BorderStyle.FixedSingle;
            bio.TabIndex = 0;
            // 
            // bioEditor
            // 
            bioEditor.Location = new Point(50, 200);
            bioEditor.Name = "bioEditor";
            bioEditor.Size = new Size(300, 400);
            bioEditor.Visible = false; // Initially hidden
            bioEditor.TabIndex = 1;
            // 
            // nameEditor
            // 
            nameEditor.Location = new Point(50, 50);
            nameEditor.Name = "nameEditor";
            nameEditor.Size = new Size(200, 30); 
            nameEditor.Visible = false; 
            nameEditor.TabIndex = 2;
            Controls.Add(nameEditor);
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStri p1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usernameToolStripMenuItem, bioToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(70, 50);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.BackColor = Color.SteelBlue;
            editToolStripMenuItem.ForeColor = Color.White;
            // 
            // add photo button
            // 
            editToolStripMenuItem.DropDownItems.Add("Upload Photo");
            editToolStripMenuItem.DropDownItems[2].Click += UploadPhotoButton_Click; //adding upload photo button to the menu
            // 
            // usernameToolStripMenuItem
            //
            usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            usernameToolStripMenuItem.Size = new Size(224, 26);
            usernameToolStripMenuItem.Text = "Username";
            usernameToolStripMenuItem.Click += usernameToolStripMenuItem_Click;
            // 
            // bioToolStripMenuItem
            // 
            bioToolStripMenuItem.Name = "bioToolStripMenuItem";
            bioToolStripMenuItem.Size = new Size(224, 26);
            bioToolStripMenuItem.Text = "Biography";
            bioToolStripMenuItem.Click += bioToolStripMenuItem_Click;
            // 
            // uploadPhoto
            // 
            PictureBox profilePictureBox = new PictureBox();
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(450, 300);  
            profilePictureBox.Location = new Point(725, 100);  
            profilePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(profilePictureBox);
            // 
            // ProfilePage
            // 
            ClientSize = new Size(2000, 1000);
            Controls.Add(name);
            Controls.Add(bio);
            Controls.Add(bioEditor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProfilePage";
            Text = "Profile Page";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();

            this.ActiveControl = name;
        }

        /*
            profile: Beck, bio1 user1, bio2 user2, bio3
            pass: Beck,password user1,apple user2,banana
        */

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem usernameToolStripMenuItem;
        private ToolStripMenuItem pictureBoxToolStripMenuItem;
        private ToolStripMenuItem bioToolStripMenuItem;
    }
}
