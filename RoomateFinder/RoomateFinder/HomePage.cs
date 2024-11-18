namespace RoomateFinder
{
    using RoomateFinderEngne;
    using System.Collections.Generic;
    using System.Windows.Forms;

    /// <summary>
    /// UI for the homepage.
    /// </summary>
    public partial class HomePage : Form
    {
        private RoomateFinderController controller;
        private List<Match> matchesList;
        ListBox matchesListBox = new ListBox();

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="controller">a reference to the controller instantiated in the login form.</param>
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

            matchesListBox.Location = new Point(100, 270);
            matchesListBox.Size = new Size(500, 400);
            matchesListBox.Click += MatchesListBox_Click;

           // Populate the ListBox with match names
            foreach (var match in matches)
            {
                matchesListBox.Items.Add(match.FirstName + " " + match.LastName);
            }

            // Add the ListBox to the form
            this.Controls.Add(matchesListBox);
            matchesListBox.Tag = matches;
        }

        private void MatchesListBox_Click(object sender, EventArgs e)
        {
            ListBox listBox = sender as ListBox;

            var index = listBox.SelectedIndex;
            if(index == 1) return;

            List<Match> matches = listBox.Tag as List<Match>;
            if(matches == null) return;

            Match selectedMatch = matches[index];

            MessageBox.Show($"You selected {selectedMatch.FirstName} {selectedMatch.LastName}");
            
        }
    }
}
 