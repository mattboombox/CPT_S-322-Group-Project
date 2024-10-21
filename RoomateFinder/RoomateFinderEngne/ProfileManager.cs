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
        private Dictionary<string, UserProfile> userProfiles = new Dictionary<string, UserProfile>();
        private string path = "profiles.csv";
        StreamReader reader = null;

        /// <summary>
        /// Constructor for the profile manager
        /// </summary>
        /// <exception cref="FileNotFoundException">if the csv file is missing an exception is thrown.</exception>
        public ProfileManager() 
        {
            if (File.Exists(path))
            {
                reader = new StreamReader(File.OpenRead(path));
            }
            else
            {
                throw new FileNotFoundException("profiles.csv not found.");
            }
            LoadProfileDictionary();
        }

        /// <summary>
        /// Adds a new user profile to the dictionary with the username as the key.
        /// </summary>
        /// <param name="username"></param>
        public void CreateNewProfile(string username)
        {
            UserProfile profile = new UserProfile();
            profile.Username = username;
            userProfiles.Add(username, profile);
        }

        /// <summary>
        /// returns the userprofile with the given username
        /// </summary>
        /// <param name="username">the user name of the profile to be loaded.</param>
        /// <returns>the user profile.</returns>
        public UserProfile LoadProfile(string username) 
        {
            return userProfiles[username];
        }

        /// <summary>
        /// reads the csv file and loads all the data into the user profile. ATTENTION: This code will have to be changed when new properties are added to the user profile!
        /// </summary>
        private void LoadProfileDictionary()
        {
            while (!reader.EndOfStream)
            {
                UserProfile profile = new UserProfile();
                var line = reader.ReadLine();
                var values = line.Split(',');
                profile.Username = values[0];
                userProfiles.Add(profile.Username, profile);
            }
        }
    }
}
