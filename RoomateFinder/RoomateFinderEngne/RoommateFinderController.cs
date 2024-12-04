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

                // Dictionary to store messages between users
        private Dictionary<string, List<Message>> messages = new Dictionary<string, List<Message>>();

        // Method to add a message
    // In RoomateFinderController
public void AddMessage(string senderUsername, string receiverUsername, string content)
{
    string key = GetConversationKey(senderUsername, receiverUsername);

    if (!messages.ContainsKey(key))
    {
        messages[key] = new List<Message>();
    }

    messages[key].Add(new Message
    {
        Sender = senderUsername,
        Receiver = receiverUsername,
        Content = content,
        Timestamp = DateTime.Now
    });

}
        // Method to retrieve messages between two users
       public List<Message> GetMessages(string user1, string user2)
{
    string key = GetConversationKey(user1, user2);

    if (messages.ContainsKey(key))
    {
        // Debug: Log retrieval
        return messages[key];
    }
    else
    {
        return new List<Message>();
    }
}

        // Helper method to create a unique key for each conversation
        private string GetConversationKey(string user1, string user2)
        {
            return user1.CompareTo(user2) < 0 ? $"{user1}_{user2}" : $"{user2}_{user1}";
        }


        /// <summary>
        /// finds the active user's profile and sets it as the currently active user.
        /// </summary>
        /// <param name="username"></param>
       public void SetActiveUser(string username)
{
    activeUser = profileManager.LoadProfile(username);
    if (activeUser == null)
    {
        throw new Exception("User profile not found.");
    }
    if (string.IsNullOrEmpty(activeUser.Username))
    {
        activeUser.Username = username; 
    }
}

        public void clearMatches()
        {
            matches.Clear();
        }

    }
}
