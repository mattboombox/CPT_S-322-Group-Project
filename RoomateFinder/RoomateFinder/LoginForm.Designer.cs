namespace RoomateFinder
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameTextBox = new TextBox();
            passwordTextBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            label3 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // usernameTextBox
            // 
            usernameTextBox.Location = new Point(370, 260); 
            usernameTextBox.Name = "usernameTextBox";
            usernameTextBox.Size = new Size(300, 30);
            usernameTextBox.Font = new Font("Segoe UI", 12);
            usernameTextBox.TabIndex = 0;
            usernameTextBox.TextChanged += usernameTextBox_TextChanged;
            usernameTextBox.PlaceholderText = "Enter your username";
            usernameTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(370, 350);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.Size = new Size(300, 30);
            passwordTextBox.Font = new Font("Segoe UI", 12);
            passwordTextBox.TabIndex = 1;
            passwordTextBox.TextChanged += passwordTextBox_TextChanged;
            passwordTextBox.UseSystemPasswordChar = true;
            passwordTextBox.PlaceholderText = "Enter your password";
            passwordTextBox.BorderStyle = BorderStyle.FixedSingle;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(370, 210);
            label1.Name = "label1";
            label1.Size = new Size(75, 15);
            label1.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label1.ForeColor = Color.DarkSlateGray;
            label1.TabIndex = 2;
            label1.Text = "Username:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(370, 310);
            label2.Name = "label2";
            label2.Size = new Size(72, 15);
            label2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            label2.ForeColor = Color.DarkSlateGray;
            label2.TabIndex = 3;
            label2.Text = "Password:";
            // 
            // button1
            // 
            button1.Location = new Point(370, 420);
            button1.Name = "button1";
            button1.Size = new Size(300, 60);
            button1.TabIndex = 4;
            button1.Text = "Login";
            button1.Font = new Font("Segoe UI", 12, FontStyle.Bold);
            button1.UseVisualStyleBackColor = true;
            button1.BackColor = Color.SteelBlue;
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(20, 20);
            button2.Name = "button2";
            button2.Size = new Size(300, 50);
            button2.TabIndex = 6;
            button2.Text = "Create Profile";
            button2.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            button2.UseVisualStyleBackColor = true;
            button2.BackColor = Color.White;
            button2.ForeColor = Color.SteelBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Click += button2_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 800);
            Controls.Add(button2);
            Controls.Add(label3);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordTextBox);
            Controls.Add(usernameTextBox);
            Name = "LoginForm";
            Text = "Login";
            Font = new Font("Segoe UI", 10);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.WhiteSmoke;
            ResumeLayout(false);
            PerformLayout();
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
