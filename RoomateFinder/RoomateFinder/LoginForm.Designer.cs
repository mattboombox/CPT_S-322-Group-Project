namespace RoomateFinder
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            var mainLayout = new TableLayoutPanel();
            var formPanel = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            passwordTextBox = new TextBox();
            usernameTextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();

            // Main layout (centers content vertically and horizontally)
            mainLayout.Dock = DockStyle.Fill;
            mainLayout.RowCount = 3;
            mainLayout.ColumnCount = 1;
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 30F)); // Spacer at the top
            mainLayout.RowStyles.Add(new RowStyle(SizeType.AutoSize));   // Centered content
            mainLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 70F)); // Spacer at the bottom

            // Form panel inside main layout
            formPanel.RowCount = 6;
            formPanel.ColumnCount = 1;
            formPanel.AutoSize = true;
            formPanel.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            formPanel.Anchor = AnchorStyles.None;

            // Username label and textbox
            label1.Text = "Username:";
            label1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.AutoSize = true;

            usernameTextBox.Font = new Font("Segoe UI", 12);
            usernameTextBox.PlaceholderText = "Enter your username";
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            usernameTextBox.Margin = new Padding(0, 10, 0, 10);
            usernameTextBox.Width = 300;

            // Password label and textbox
            label2.Text = "Password:";
            label2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.AutoSize = true;

            passwordTextBox.Font = new Font("Segoe UI", 12);
            passwordTextBox.PlaceholderText = "Enter your password";
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            passwordTextBox.Margin = new Padding(0, 10, 0, 10);
            passwordTextBox.Width = 300;

            // Login button
            button1.Text = "Login";
            button1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Width = 300;
            button1.Height = 40;
            button1.Margin = new Padding(0, 20, 0, 0);
            button1.Click += button1_Click;

            // Error label
            label3.Text = string.Empty;
            label3.Font = new Font("Segoe UI", 10, FontStyle.Italic);
            label3.ForeColor = Color.Red;
            label3.AutoSize = true;

            // Add form elements to the formPanel
            formPanel.Controls.Add(label1);
            formPanel.Controls.Add(usernameTextBox);
            formPanel.Controls.Add(label2);
            formPanel.Controls.Add(passwordTextBox);
            formPanel.Controls.Add(label3);
            formPanel.Controls.Add(button1);

            // Add formPanel to the mainLayout
            mainLayout.Controls.Add(formPanel, 0, 1);

            // Create Profile button
            button2.Text = "Create Profile";
            button2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button2.BackColor = Color.White;
            button2.ForeColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Size = new Size(150, 40);
            button2.Location = new Point(20, 20); // Fixed position
            button2.Click += button2_Click;
            Controls.Add(button2);

            // Add mainLayout to the form
            Controls.Add(mainLayout);

            // Form properties
            AutoScaleDimensions = new SizeF(96F, 96F);
            AutoScaleMode = AutoScaleMode.Dpi;
            ClientSize = new Size(1000, 800);
            Text = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
        }


        #endregion

        private TextBox usernameTextBox;
        private TextBox passwordTextBox;
        private Label label1;
        private Label label2;
        private Button button1;
        private Label label3;
        private Button button2;    
    }
}
