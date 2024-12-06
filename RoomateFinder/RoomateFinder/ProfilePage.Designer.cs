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

            SuspendLayout();

            // MenuStrip
            menuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1280, 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.BackColor = Color.SteelBlue;
            menuStrip1.ForeColor = Color.White;
            menuStrip1.Font = new Font("Segoe UI", 12, FontStyle.Bold);

            // Edit Menu
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[]
            {
                usernameToolStripMenuItem,
                bioToolStripMenuItem,
                uploadPhotoToolStripMenuItem
            });
            editToolStripMenuItem.Text = "Edit";

            // Edit Username
            usernameToolStripMenuItem.Text = "Edit Username";
            usernameToolStripMenuItem.Click += usernameToolStripMenuItem_Click;

            // Edit Biography
            bioToolStripMenuItem.Text = "Edit Biography";
            bioToolStripMenuItem.Click += bioToolStripMenuItem_Click;

            // Upload Photo
            uploadPhotoToolStripMenuItem.Text = "Upload Photo";
            uploadPhotoToolStripMenuItem.Click += UploadPhotoButton_Click;

            // Profile Panel
            profilePanel.Dock = DockStyle.Fill;
            profilePanel.Padding = new Padding(20);

            // TableLayoutPanel for structured layout
            var tableLayout = new TableLayoutPanel
            {
                Dock = DockStyle.Fill,
                ColumnCount = 2,
                RowCount = 2,
                Padding = new Padding(10),
                AutoSize = true
            };
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 250F)); 
            tableLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F)); 
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 250F)); 
            tableLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F)); 

            // Profile PictureBox
            profilePictureBox.Size = new Size(200, 200);
            profilePictureBox.Dock = DockStyle.Fill;
            profilePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            profilePictureBox.BorderStyle = BorderStyle.Fixed3D;
            profilePictureBox.BackColor = Color.LightGray;
            tableLayout.Controls.Add(profilePictureBox, 0, 0);

            // Username Label
            name.Text = "John Doe"; 
            name.Font = new Font("Segoe UI", 24, FontStyle.Bold);
            name.ForeColor = Color.DarkSlateGray;
            name.Dock = DockStyle.Fill;
            name.TextAlign = ContentAlignment.MiddleLeft;
            tableLayout.Controls.Add(name, 1, 0);

            // Biography Label
            bio.Text = "This is a sample biography."; 
            bio.Font = new Font("Segoe UI", 14);
            bio.ForeColor = Color.Black;
            bio.BackColor = Color.WhiteSmoke;
            bio.Padding = new Padding(10);
            bio.Dock = DockStyle.Fill;
            bio.TextAlign = ContentAlignment.TopLeft;
            tableLayout.SetColumnSpan(bio, 2); 
            tableLayout.Controls.Add(bio, 0, 1);

            // Add TableLayoutPanel to Profile Panel
            profilePanel.Controls.Add(tableLayout);

            // Profile Page
            ClientSize = new Size(1280, 720);
            Controls.Add(profilePanel);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Text = "Profile Page";
            BackColor = Color.Gainsboro;
            StartPosition = FormStartPosition.CenterScreen;

            ResumeLayout(false);
            PerformLayout();
        }
    }
}