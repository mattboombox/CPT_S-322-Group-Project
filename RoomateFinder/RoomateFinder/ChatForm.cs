using RoomateFinderEngne;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace RoomateFinder
{
    public class ChatForm : Form
    {
        private RoomateFinderController controller;
        private UserProfile activeUser;
        private Match match;

        private Panel messagesPanel;
        private TextBox messageTextBox;
        private Button sendButton;
        private System.Windows.Forms.Timer refreshTimer;

        public ChatForm(RoomateFinderController controller, Match match)
{
    this.controller = controller;
    this.activeUser = controller.GetActiveUser();
    this.match = match ?? throw new ArgumentNullException(nameof(match));

    InitializeComponent();
    LoadMessages();
}

        private void InitializeComponent()
        {
            // Form properties
            this.Text = $"Chat with {match.FirstName} {match.LastName}";
            this.ClientSize = new Size(500, 675);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.MinimumSize = new Size(400, 500);

            // Messages display panel
            messagesPanel = new Panel
            {
                Location = new Point(10, 10),
                Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 100),
                AutoScroll = true,
                BorderStyle = BorderStyle.FixedSingle,
                Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                BackColor = Color.White
            };
            this.Controls.Add(messagesPanel);

            // Message input box
            messageTextBox = new TextBox
            {
                Location = new Point(10, this.ClientSize.Height - 70),
                Size = new Size(this.ClientSize.Width - 100, 50),
                Multiline = true,
                Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right,
                Font = new Font("Segoe UI", 10)
            };
            this.Controls.Add(messageTextBox);

            // Send button
            sendButton = new Button
            {
                Text = "Send",
                Location = new Point(this.ClientSize.Width - 80, this.ClientSize.Height - 70),
                Size = new Size(90, 50),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right,
                Font = new Font("Segoe UI", 10),
                BackColor = Color.SteelBlue,
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };
            sendButton.Click += SendButton_Click;
            this.Controls.Add(sendButton);

            // Adjust controls when the form is resized
            this.Resize += ChatForm_Resize;
        }

        private void ChatForm_Resize(object sender, EventArgs e)
        {
            // Adjust the positions and sizes of controls when the form is resized
            messagesPanel.Size = new Size(this.ClientSize.Width - 20, this.ClientSize.Height - 100);
            messageTextBox.Location = new Point(10, this.ClientSize.Height - 70);
            messageTextBox.Size = new Size(this.ClientSize.Width - 100, 50);
            sendButton.Location = new Point(this.ClientSize.Width - 80, this.ClientSize.Height - 70);
        }

        // Load and display messages with improved styling
        private void LoadMessages()
        {
            var messages = controller.GetMessages(activeUser.Username, match.Username);

            messagesPanel.Controls.Clear();

            int yOffset = 10;
            foreach (var message in messages)
            {
                Label messageLabel = new Label
                {
                    AutoSize = true,
                    MaximumSize = new Size(messagesPanel.Width - 40, 0),
                    Font = new Font("Segoe UI", 10),
                    Padding = new Padding(10),
                    BackColor = message.Sender == activeUser.Username ? Color.LightBlue : Color.LightGray,
                    ForeColor = Color.Black,
                    Text = $"{message.Content}\n\n{message.Timestamp.ToString("g")}",
                    Location = new Point(10, yOffset),
                    BorderStyle = BorderStyle.FixedSingle
                };

                // Adjust the width and alignment based on the sender
                if (message.Sender == activeUser.Username)
                {
                    messageLabel.Location = new Point(messagesPanel.Width - messageLabel.PreferredWidth - 10, yOffset);
                    messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
                }
                else
                {
                    messageLabel.Location = new Point(10, yOffset);
                    messageLabel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                }

                messagesPanel.Controls.Add(messageLabel);
                yOffset += messageLabel.Height + 10;
            }

            // Scroll to the bottom
            messagesPanel.VerticalScroll.Value = messagesPanel.VerticalScroll.Maximum;
            messagesPanel.PerformLayout();
        }
        private void SendButton_Click(object sender, EventArgs e)
        {
            var content = messageTextBox.Text.Trim();

            if (!string.IsNullOrEmpty(content))
            {
                controller.AddMessage(activeUser.Username, match.Username, content);
                messageTextBox.Clear();
                LoadMessages();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            // Stop the refresh timer when the form is closed
            refreshTimer?.Stop();
        }
    }
}
