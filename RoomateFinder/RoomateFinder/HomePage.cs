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

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="controller">a reference to the controller instantiated in the login form.</param>
        public HomePage(RoomateFinderController controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.Text = "RoomMate Finder Homepage"; // Updated title
        }




        private void HomePage_Load(object sender, EventArgs e)
        {
            // This code will execute when the HomePage loads
            LoadMatches();
        }

        private void LoadMatches()
        {
            List<Match> matches = controller.GetMatches();  // Get the list of matches

            ListBox matchesListBox = new ListBox();  // Create a ListBox to display the matches

            matchesListBox.Location = new Point(100, 270);
            matchesListBox.Size = new Size(500, 400);

           // Populate the ListBox with match names
            foreach (var match in matches)
            {
                matchesListBox.Items.Add(match.FirstName + " " + match.LastName);
            }

            // Add the ListBox to the form
            this.Controls.Add(matchesListBox);
        }

        /// <summary>
        /// Event handler for when the "View Details" button is clicked.
        /// </summary>
        private void DetailsButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Roommate details coming soon!", "Details", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
