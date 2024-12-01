namespace RoomateFinder
{
    using RoomateFinderEngne;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// UI for the homepage.
    /// </summary>
    public partial class HomePage : Form
    {
        private RoomateFinderController controller;
        private List<Match> matchesList;
        private ListBox matchesListBox;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="controller">A reference to the controller instantiated in the login form.</param>
        public HomePage(RoomateFinderController controller)
        {
            this.controller = controller;
            InitializeComponent();
            LoadMatches();
            this.Text = "RoomMate Finder Homepage"; // Updated title
        }

        private void HomePage_Load(object sender, EventArgs e)
        {
        }

        private void LoadMatches()
        {
            List<Match> matches = controller.GetMatches();  // Get the list of matches

            matchesListBox.Items.Clear();

            // Populate the ListBox with match names
            foreach (var match in matches)
            {
                matchesListBox.Items.Add($"{match.FirstName} {match.LastName}");
            }

            // Store matches in the Tag property for later use
            matchesListBox.Tag = matches;
        }

        private void MatchesListBox_Click(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;

            var index = listBox.SelectedIndex;
            if (index == -1) return; // Ensure an item is selected

            List<Match> matches = listBox.Tag as List<Match>;
            if (matches == null || index >= matches.Count) return;

            Match selectedMatch = matches[index];

            // Open the ChatForm for the selected match
            ChatForm chatForm = new ChatForm(controller, selectedMatch);
            chatForm.Show();
        }
    }
}
