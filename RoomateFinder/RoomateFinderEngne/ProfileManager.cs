using System;
using System.Net;
using System.Threading.Channels;


namespace RoomateFinderEngne
{
    /// <summary>
    /// reads from a file and populates a dictionary with user profiles. These profiles can then be accessed, worked on, removed, added to etc.
    /// </summary>
    public class ProfileManager 
    {
        /// <summary>
        /// stores the users username as a key and its profile as its value.
        /// </summary>
        private Dictionary<string, UserProfile> userProfiles = new Dictionary<string, UserProfile>();
        private string path = "profiles.csv";

        private static List<RoomateFinder.User> users = new List<RoomateFinder.User>();

        StreamReader reader = null;
        StreamWriter writer = null;

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
        /// <param name="bio"></param>
        public void CreateNewProfile(string username, string bio)
        {
            UserProfile profile = new UserProfile();
            profile.Username = username;
            profile.Bio = bio;
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
        public void LoadProfileDictionary()
        {
            if (File.Exists(path))
            {
                using (StreamReader reader = new StreamReader(File.OpenRead(path)))
                {
                    while (!reader.EndOfStream)
                    {
                        UserProfile profile = new UserProfile();
                        var line = reader.ReadLine();
                        var values = line.Split(',');
                        profile.Username = values[0];
                        profile.Bio = values[1];
                        userProfiles.Add(profile.Username, profile);
                    }
                }
                reader?.Close();
            }
            else
            {
                throw new FileNotFoundException("profiles.csv not found.");
            }
        }


        // function to save new bio to user profile
        public void UpdateUserProfile(string username, string bio)
        {
            if (userProfiles.ContainsKey(username))
            {
                userProfiles[username].Bio = bio;
                SaveProfilesToCsv();
            }
        }

        // function to save updated profile to csv spreadsheet
        private void SaveProfilesToCsv()
        {

            using (StreamWriter writer = new StreamWriter(path))
            {
                foreach (var profile in userProfiles.Values)
                {
                    writer.WriteLine($"{profile.Username},{profile.Bio}");
                }
                writer?.Close();
            }
            
        }

        public static RoomateFinder.User GetUserByUsername(string username)
        {
            return users.FirstOrDefault(u => u.Username == username);
        }
        public void UpdateUserProfile(string username, string bio, string profilePhotoUrl = null)
        {
            var user = GetUserByUsername(username);
            if (user != null)
            {
                user.Bio = bio;
                if (!string.IsNullOrEmpty(profilePhotoUrl))
                {
                    user.ProfilePhotoUrl = profilePhotoUrl;
                }
            }
        }
    }
}
