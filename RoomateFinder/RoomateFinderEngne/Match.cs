namespace RoomateFinderEngne
{
    /// <summary>
    /// Contains all the information on a specific user, with the exception of passwords.
    /// </summary>
    public class Match
    {
        // Private backing fields
        private string _firstName;
        private string _lastName;

        // Public properties with proper naming and backing fields
        public string FirstName 
        { 
            get { return _firstName; } 
            set { _firstName = value; UpdateName(); } 
        }

        public string LastName 
        { 
            get { return _lastName; } 
            set { _lastName = value; UpdateName(); } 
        }

           public Match(string FirstName, string LastName)
        {
            _firstName = FirstName;
            _lastName = LastName;
            UpdateName();
        }


        // Public property for full name (read-only)
        public string Name { get; private set; }

        /// <summary>
        /// Updates the full name when first or last name changes.
        /// </summary>
        private void UpdateName()
        {
            Name = _firstName + " " + _lastName;
        }
    }
}
