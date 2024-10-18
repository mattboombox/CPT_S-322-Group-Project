using System;


namespace RoomateFinderEngne
{
    internal class Login
    {
        
        private string username = "emptyName";

        private string password = "emptyPassword";

        public string Username { get { return username; } set { username = value; } }
        public string Password { get { return password; } set { password = value; } }

        public void CreateNewUser()
        {

        }

        public bool ValidateUserInfo()
        {
            bool validated = false;


            return validated;
        }
    }
}
