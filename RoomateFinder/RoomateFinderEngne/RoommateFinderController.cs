using System.ComponentModel.Design;
using System.Diagnostics;

/*
    TODO: Beck: 
        fully implement new profile creation.
        implement code to save the dictionarys to the csv files (both passwords and profiles)
        incryption method for passwords.
 
 */
namespace RoomateFinderEngne
{
    /// <summary>
    /// Controlls all the primary actions of the program.
    /// </summary>
    public class RoomateFinderController
    {
        /// <summary>
        /// the user that is logged in.
        /// </summary>
        private UserProfile activeUser;

        /// <summary>
        /// manager for the user profiles.
        /// </summary>
        private ProfileManager profileManager;

        /// <summary>
        /// login process object.
        /// </summary>
        public Login newLogin;

        public List<Match> matches = new List<Match>();


        public void AddMatch(Match match)
        {
            matches.Add(match);

        }
        public List<Match> GetMatches()
        {
            return matches;
        }

        public UserProfile GetActiveUser()
        {
            return activeUser;
        }

        public string test;
        public RoomateFinderController()
        {
           newLogin = new Login();
           profileManager = new ProfileManager();
        }

        /// <summary>
        /// finds the active user's profile and sets it as the currently active user.
        /// </summary>
        /// <param name="username"></param>
        public void SetActiveUser(string username)
        {
            activeUser = profileManager.LoadProfile(username);
            test = activeUser.Username; // just used to test that the active user was set correctly, Remove before final product.
        }

    }
}
