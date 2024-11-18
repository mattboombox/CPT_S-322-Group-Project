using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace RoomateFinderEngne
{
    /// <summary>
    /// Contains methods and properties used in the logout process.
    /// </summary>
    public class LogoutManager
    {
        private readonly string filePath;

        public LogoutManager(string filePath = "profiles.csv")
        {
            this.filePath = filePath;
        }

        public void LogoutUser(UserProfile user)
        {
            if (user == null)
            {
                throw new ArgumentNullException(nameof(user), "User cannot be null.");
            }

            SaveUserData(user);
        }

        private void SaveUserData(UserProfile user)
        {
            // Checks the CSV file to see if username already exists.
            // If true, overwrites; if false, creates a new line with user info.
            try
            {
                // Read all lines from the file
                var lines = File.Exists(filePath)
                    ? File.ReadAllLines(filePath).ToList()
                    : new List<string>();

                // Check if the user exists
                bool userFound = false;
                for (int i = 0; i < lines.Count; i++)
                {
                    var line = lines[i];
                    var parts = line.Split(", ");

                    if (parts.Length == 2 && parts[0] == user.Username)
                    {
                        // Update the bio if the user exists
                        lines[i] = $"{user.Username}, {user.Bio}";
                        userFound = true;
                        break;
                    }
                }

                // User DNE, add new line
                if (!userFound)
                {
                    lines.Add($"{user.Username}, {user.Bio}");
                }

                // Write all lines back to the file
                File.WriteAllLines(filePath, lines);

                Console.WriteLine(userFound
                    ? "User info updated in profiles.csv."
                    : "New user info saved to profiles.csv.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving or updating user info: {ex.Message}");
            }
        }
    }
}
