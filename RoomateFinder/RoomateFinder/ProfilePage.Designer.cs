//Information like a users name, email, phone number, and a short bio will be displayed on the profile page.
namespace RoomateFinder
{
    partial class ProfilePage{
        private Label name;
        private Label bio;
        private TextBox bioEditor;

        private void InitializeComponent()
        {
            name = new Label();
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
            name.Location = new Point(50, 50);
            name.Name = "name";
            name.Size = new Size(50, 30);
            name.TabIndex = 0;
            // 
            // bio
            // 
            bio.Location = new Point(50, 200);
            bio.Name = "bio";
            bio.Size = new Size(300, 400);
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
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { usernameToolStripMenuItem, bioToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(49, 24);
            editToolStripMenuItem.Text = "Edit";
            // 
            // usernameToolStripMenuItem
            // 
            usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            usernameToolStripMenuItem.Size = new Size(224, 26);
            usernameToolStripMenuItem.Text = "Username";
            // 
            // bioToolStripMenuItem
            // 
            bioToolStripMenuItem.Name = "bioToolStripMenuItem";
            bioToolStripMenuItem.Size = new Size(224, 26);
            bioToolStripMenuItem.Text = "Bio";
            bioToolStripMenuItem.Click += bioToolStripMenuItem_Click;
            // 
            // ProfilePage
            // 
            ClientSize = new Size(800, 450);
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

        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem usernameToolStripMenuItem;
        private ToolStripMenuItem bioToolStripMenuItem;
    }
}
