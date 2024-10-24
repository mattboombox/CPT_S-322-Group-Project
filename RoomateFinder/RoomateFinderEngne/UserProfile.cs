using System;

namespace RoomateFinderEngne
{
    /// <summary>
    /// contains all the information on a specific user, with the exception of passwords.
    /// </summary>
    public class UserProfile
    {
        private string username;
        private string bio; 
        public string Username { get { return username; } set { username = value; } }

        public string Bio {  get { return bio; } set { bio = value;  } }
        
    }
}
