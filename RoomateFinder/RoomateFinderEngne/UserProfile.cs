using System;

namespace RoomateFinderEngne
{
    /// <summary>
    /// contains all the information on a specific user, with the exception of passwords.
    /// </summary>
    internal class UserProfile
    {
        private string username;
        public string Username { get { return username; } set { username = value; } }
        
    }
}
