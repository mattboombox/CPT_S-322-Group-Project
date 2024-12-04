using System;
using Microsoft.VisualBasic;

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
            string username = Microsoft.VisualBasic.Interaction.InputBox("Enter your username here", "Create New User", "Username");
            string password = Microsoft.VisualBasic.Interaction.InputBox("Enter password here", "Create Password", "password");        
            string Email = Microsoft.VisualBasic.Interaction.InputBox("Enter Email", "Email", "Email");
            string bio = Microsoft.VisualBasic.Interaction.InputBox("Enter your biography here", "Create Bio", "Bio");
            var projectDirectory = AppDomain.CurrentDomain.BaseDirectory;
            projectDirectory = Path.GetFullPath(Path.Combine(projectDirectory, @"..\..\.."));
            var filePath = Path.Combine(projectDirectory, "profiles.csv");

            File.AppendAllText(filePath, "\n" + username + ", " + bio);

            filePath = Path.Combine(projectDirectory, "passwords.csv");

            File.AppendAllText( filePath, "\n" + username + "," + password);

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