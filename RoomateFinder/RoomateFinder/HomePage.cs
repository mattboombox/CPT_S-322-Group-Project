namespace RoomateFinder
{
    using RoomateFinderEngne;

    /// <summary>
    /// UI for the homepage.
    /// </summary>
    public partial class HomePage : Form
    {
        private RoomateFinderController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="HomePage"/> class.
        /// </summary>
        /// <param name="controller"> a reference to the controller instantiated in the login form.</param>
        public HomePage(RoomateFinderController controller)
        {
            this.controller = controller;
            InitializeComponent();
            this.Text = controller.test; // just used to test that the active user was set correctly, Remove before final product.
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
