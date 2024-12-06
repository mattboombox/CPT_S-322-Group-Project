namespace RoomateFinder
{
    partial class SurveyUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
    private void InitializeComponent()
    {

        int startX = 20; 
        int startY = 20;
        int yOffset = 120; 

        Panel scrollablePanel = new Panel();
        scrollablePanel.Dock = DockStyle.Fill;
        scrollablePanel.AutoScroll = true;

        label1 = new Label();
        textBox1 = new TextBox();
        label2 = new Label();
        textBox2 = new TextBox();
        label3 = new Label();
        textBox3 = new TextBox();
        label4 = new Label();
        textBox4 = new TextBox();
        label5 = new Label();
        textBox5 = new TextBox();
        label6 = new Label();
        textBox6 = new TextBox();
        label7 = new Label();
        textBox7 = new TextBox();
        label8 = new Label();
        textBox8 = new TextBox();
        label9 = new Label();
        textBox9 = new TextBox();
        label10 = new Label();
        textBox10 = new TextBox();
        label11 = new Label();
        textBox11 = new TextBox();
        label12 = new Label();
        textBox12 = new TextBox();
        label13 = new Label();
        textBox13 = new TextBox();
        label14 = new Label();
        textBox14 = new TextBox();
        label15 = new Label();
        textBox15 = new TextBox();
        label16 = new Label();
        textBox16 = new TextBox();
        label17 = new Label();
        textBox17 = new TextBox();
        label18 = new Label();
        textBox18 = new TextBox();
        label19 = new Label();
        textBox19 = new TextBox();
        label20 = new Label();
        textBox20 = new TextBox();
        SubmitButton = new Button();
        label21 = new Label();

        SuspendLayout();

        label21.Text = "Roommate Preference Survey\nPlease respond to all questions.";
        label21.Font = new Font("Segoe UI", 18, FontStyle.Bold);
        label21.Size = new Size(960, 60);
        label21.TextAlign = ContentAlignment.MiddleCenter;
        label21.Location = new Point((1000 - label21.Width) / 2, startY);
        scrollablePanel.Controls.Add(label21);

        AddQuestion(scrollablePanel, label1, textBox1, startX, startY + 70, "\"How clean and organized do you keep your living space? Very clean, Moderately clean, A bit messy, Very messy\"");
        AddQuestion(scrollablePanel, label2, textBox2, startX, startY + 1 * (yOffset+40), "\"What time do you usually go to bed on weekdays? Before 9 PM, 9 to 11 PM, 11 PM to 1 AM, After 1 AM\"");
        AddQuestion(scrollablePanel, label3, textBox3, startX, startY + 2 * yOffset, "\"What time do you typically wake up on weekdays? 6 AM, 6 to 8 AM, 8 to 10 AM, After 10 AM\"");
        AddQuestion(scrollablePanel, label4, textBox4, startX, startY + 3 * yOffset, "\"How often do you cook at home? Daily, A few times a week, Occasionally, Rarely/Never\"");
        AddQuestion(scrollablePanel, label5, textBox5, startX, startY + 4 * yOffset, "\"How do you feel about guests coming over frequently? Love it, occasionally mind it, Prefer infrequently, Prefer no guests\"");            AddQuestion(scrollablePanel, label6, textBox6, startX, startY + 5 * yOffset, "\"Do you smoke or are you okay with smoking indoors? I smoke frequently, I smoke sometimes, I do not smoke but I'm ok with it, Not okay with smoking\"");
        AddQuestion(scrollablePanel, label7, textBox7, startX, startY + 6 * yOffset, "\"Do you drink alcohol? Often, Occasionally, Rarely, Never\"");
        AddQuestion(scrollablePanel, label8, textBox8, startX, startY + 7 * yOffset, "\"Are you comfortable living with pets? Cats, Dogs, Both, None\"");
        AddQuestion(scrollablePanel, label9, textBox9, startX, startY + 8 * yOffset, "\"What level of noise are you comfortable with? Silence, Moderate noise, Ok with loud noise, I will be making the loud noise\"");            AddQuestion(scrollablePanel, label10, textBox10, startX, startY + 9 * yOffset, "\"Do you work from home or spend most of your time at home? Fully remote, Hybrid, Always away, Unemployed\"");
        AddQuestion(scrollablePanel, label11, textBox11, startX, startY + 10 * yOffset, "\"Are you ok with sharing a space with a roommate's significant other? Yes no issues, Yes but they cannot spend the night, No but they can visit, No relationships allowed inside\"");
        AddQuestion(scrollablePanel, label12, textBox12, startX, startY + 11 * yOffset, "\"How do you feel about hosting events or parties in the shared space? 24/7 party, Ok with occasional events, Prefer small gatherings, No parties ever\"");
        AddQuestion(scrollablePanel, label13, textBox13, startX, startY + 12 * yOffset, "\"Whats your preferred indoor temperature? Hot, warm, Room temperature, Freezing\"");
        AddQuestion(scrollablePanel, label14, textBox14, startX, startY + 13 * yOffset, "\"Are you okay with splitting costs for shared items or services? Never, only for cheap stuff, Often, Always\"");
        AddQuestion(scrollablePanel, label15, textBox15, startX, startY + 14 * yOffset, "\"Are you punctual with rent and utility payments? Always, Sometimes, Rarely, Never\"");
        AddQuestion(scrollablePanel, label16, textBox16, startX, startY + 15 * yOffset, "\"Would you prefer to be friends with your roommate or keep it professional? Best friends, friends, neutral, enemies\"");
        AddQuestion(scrollablePanel, label17, textBox17, startX, startY + 16 * yOffset, "\"How do you feel about decorating shared spaces? Would enjoy decorating together, Okay with it occasionally, Prefer no changes, Only I can decorate\"");
        AddQuestion(scrollablePanel, label18, textBox18, startX, startY + 17 * yOffset, "\"Are you comfortable sharing items? No sharing, minimal sharing, open to sharing, abolish private property\"");
        AddQuestion(scrollablePanel, label19, textBox19, startX, startY + 18 * yOffset, "\"How much personal space do you need? I need a lot of alone time, Moderate balance, I enjoy spending time with others often, I cannot be alone\"");
        AddQuestion(scrollablePanel, label20, textBox20, startX, startY + 19 * yOffset, "\"How do you prefer to resolve conflicts? Open discussion, Mediated conversation, Avoid confrontation, Physical combat\"");

        SubmitButton.Text = "Submit";
        SubmitButton.Font = new Font("Segoe UI", 14, FontStyle.Bold);
        SubmitButton.Size = new Size(200, 50);
        SubmitButton.Location = new Point((1000 - SubmitButton.Width) / 2, startY + 20 * yOffset-40);
        SubmitButton.UseVisualStyleBackColor = true;
        SubmitButton.BackColor = Color.SteelBlue;
        SubmitButton.Click += SubmitButton_Click;
        scrollablePanel.Controls.Add(SubmitButton);
        this.Controls.Add(scrollablePanel);
        this.Size = new Size(1000, 800);

        ResumeLayout(false);
        PerformLayout();
    }

    private void AddQuestion(Panel panel, Label label, TextBox textBox, int x, int y, string text)
    {
        label.AutoSize = true;
        label.Location = new Point(x, y);
        label.Size = new Size(460, 40);
        label.Text = text;
        panel.Controls.Add(label);

        textBox.Location = new Point(x, y + 40);
        textBox.Size = new Size(250, 27);
        panel.Controls.Add(textBox);
    }


        #endregion

        private Label label1;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label2;
        private TextBox textBox3;
        private Label label3;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox5;
        private Label label5;
        private TextBox textBox6;
        private Label label6;
        private TextBox textBox7;
        private Label label7;
        private TextBox textBox8;
        private Label label8;
        private TextBox textBox9;
        private Label label9;
        private TextBox textBox10;
        private Label label10;

        private TextBox textBox11;
        private Label label11;
        private TextBox textBox12;
        private Label label12;
        private TextBox textBox13;
        private Label label13;
        private TextBox textBox14;
        private Label label14;
        private TextBox textBox15;
        private Label label15;
        private TextBox textBox16;
        private Label label16;
        private TextBox textBox17;
        private Label label17;
        private TextBox textBox18;
        private Label label18;
        private TextBox textBox19;
        private Label label19;
        private TextBox textBox20;
        private Label label20;
        private Button SubmitButton;
        private Label label21;
    }
}