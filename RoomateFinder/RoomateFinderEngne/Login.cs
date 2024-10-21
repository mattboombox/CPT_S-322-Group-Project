using System;


namespace RoomateFinderEngne
{
    /// <summary>
    /// Contains methods and properties used in the login process.
    /// </summary>
    public class Login
    {
        private string username = "emptyName";
        private string password = "emptyPassword";
        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

        /// <summary>
        /// creates a new user.
        /// </summary>
        public void CreateNewUser()
        {

        }

        /// <summary>
        /// validates the user info.
        /// </summary>
        /// <returns>true if the user info is correct.</returns>
        public bool ValidateUserInfo()
        {
            bool success = false;
            PasswordManager pV = new PasswordManager();

            if (pV.Validate(username, password)) 
            {
                success = true;
            }

            return success;
            
        }
    }
}
