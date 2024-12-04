namespace RoomateFinder
{
    partial class ProfilePage
    {
        private Label name;
        private Label bio;
        private TextBox nameEditor;
        private TextBox bioEditor;
        private PictureBox profilePictureBox;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem usernameToolStripMenuItem;
        private ToolStripMenuItem bioToolStripMenuItem;
        private ToolStripMenuItem uploadPhotoToolStripMenuItem;
        private Panel profilePanel;

        private void InitializeComponent()
        {
            // Initialize components
            name = new Label();
            nameEditor = new TextBox();
            bio = new Label();
            bioEditor = new TextBox();
            profilePictureBox = new PictureBox();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            usernameToolStripMenuItem = new ToolStripMenuItem();
            bioToolStripMenuItem = new ToolStripMenuItem();
            uploadPhotoToolStripMenuItem = new ToolStripMenuItem();
            profilePanel = new Panel();

            // Suspend layout for performance
            SuspendLayout();

            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1500, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] {
            usernameToolStripMenuItem,
            bioToolStripMenuItem,
            uploadPhotoToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(55, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.ForeColor = Color.White;

            // 
            // usernameToolStripMenuItem
            // 
            usernameToolStripMenuItem.Name = "usernameToolStripMenuItem";
            usernameToolStripMenuItem.Size = new Size(190, 28);
            usernameToolStripMenuItem.Text = "Edit Username";
            usernameToolStripMenuItem.Click += usernameToolStripMenuItem_Click;

            // 
            // bioToolStripMenuItem
            // 
            bioToolStripMenuItem.Name = "bioToolStripMenuItem";
            bioToolStripMenuItem.Size = new Size(190, 28);
            bioToolStripMenuItem.Text = "Edit Biography";
            bioToolStripMenuItem.Click += bioToolStripMenuItem_Click;

            // 
            // uploadPhotoToolStripMenuItem
            // 
            uploadPhotoToolStripMenuItem.Name = "uploadPhotoToolStripMenuItem";
            uploadPhotoToolStripMenuItem.Size = new Size(190, 28);
            uploadPhotoToolStripMenuItem.Text = "Upload Photo";
            uploadPhotoToolStripMenuItem.Click += UploadPhotoButton_Click;

            // 
            // profilePanel
            // 
            profilePanel.Location = new Point(50, 50);
            profilePanel.Size = new Size(1400, 900);
            profilePanel.BorderStyle = BorderStyle.FixedSingle;
            profilePanel.BackColor = Color.WhiteSmoke;
            profilePanel.Padding = new Padding(20);

            // 
            // profilePictureBox
            // 
            profilePictureBox.Name = "profilePictureBox";
            profilePictureBox.Size = new Size(300, 300);
            profilePictureBox.Location = new Point(50, 20);
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox.BorderStyle = BorderStyle.Fixed3D;
            profilePictureBox.BackColor = Color.LightGray;
            profilePanel.Controls.Add(profilePictureBox);

            // 
            // name
            // 
            name.Location = new Point(400, 20);
            name.Name = "name";
            name.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            name.Size = new Size(950, 100);
            name.ForeColor = Color.DarkSlateGray;
            name.TabIndex = 1;
            name.TextAlign = ContentAlignment.MiddleLeft;
            profilePanel.Controls.Add(name);

            // 
            // nameEditor
            // 
            nameEditor.Location = new Point(400, 20);
            nameEditor.Name = "nameEditor";
            nameEditor.Size = new Size(950, 50);
            nameEditor.Font = new Font("Segoe UI", 28, FontStyle.Bold);
            nameEditor.Visible = false;
            profilePanel.Controls.Add(nameEditor);

            // 
            // bio
            // 
            bio.Location = new Point(50, 350);
            bio.Name = "bio";
            bio.Size = new Size(1300, 500);
            bio.BorderStyle = BorderStyle.None;
            bio.Font = new Font("Segoe UI", 14);
            bio.AutoSize = false;
            bio.TextAlign = ContentAlignment.TopLeft;
            bio.BackColor = Color.WhiteSmoke;
            bio.ForeColor = Color.Black;
            bio.Padding = new Padding(10);
            bio.TabIndex = 2;
            profilePanel.Controls.Add(bio);

            // 
            // bioEditor
            // 
            bioEditor.Location = new Point(50, 350);
            bioEditor.Name = "bioEditor";
            bioEditor.Size = new Size(1300, 500);
            bioEditor.Multiline = true;
            bioEditor.Font = new Font("Segoe UI", 14);
            bioEditor.Visible = false;
            bioEditor.ScrollBars = ScrollBars.Vertical;
            profilePanel.Controls.Add(bioEditor);

            // 
            // ProfilePage
            // 
            ClientSize = new Size(1500, 1000);
            Controls.Add(profilePanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "ProfilePage";
            Text = "Profile Page";
            BackColor = Color.Gainsboro;
            StartPosition = FormStartPosition.CenterScreen;

            // Add subtle shadow effect
            profilePanel.BorderStyle = BorderStyle.FixedSingle;
            profilePanel.BackColor = Color.White;

            // Resume layout
            ResumeLayout(false);
            PerformLayout();
        }
    }
}