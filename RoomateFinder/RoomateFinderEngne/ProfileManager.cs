using System;


namespace RoomateFinderEngne
{
    /// <summary>
    /// reads from a file and populates a dictionary with user profiles. These profiles can then be accessed, worked on, removed, added to etc.
    /// </summary>
    internal class ProfileManager
    {
        /// <summary>
        /// stores the users username as a key and its profile as its value.
        /// </summary>
        private Dictionary<string, UserProfile> UserProfiles = new Dictionary<string, UserProfile>();

        public void CreateNewProfile(string username, string password)
        {

        }

        public UserProfile LoadProfile(string username) 
        {
            return UserProfiles[username];
        }


    }
}
