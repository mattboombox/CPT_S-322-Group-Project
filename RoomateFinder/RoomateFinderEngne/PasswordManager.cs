using System;

namespace RoomateFinderEngne
{
    /// <summary>
    /// manages various functions related to the passwords.
    /// </summary>
    internal class PasswordManager
    {
        /// <summary>
        /// dictionary for all the passwords.
        /// </summary>
        private Dictionary<string, string> passwordDictionary = new Dictionary<string, string>();

        /// <summary>
        /// name of the password csv file.
        /// </summary>
        private string path = "passwords.csv";

        /// <summary>
        /// file stream used to read the password csv file.
        /// </summary>
        StreamReader reader = null;

        /// <summary>
        /// Constructor for the PasswordManager
        /// </summary>
        /// <exception cref="FileNotFoundException">throws an exception if the password.csv file is not found.</exception>
        public PasswordManager() 
        {
            if (File.Exists(path))
            {
                reader = new StreamReader(File.OpenRead(path));
            }
            else 
            {
                throw new FileNotFoundException("passwords.csv not found.");
            }

            LoadPasswordDictionary();
        }

        /// <summary>
        /// loads the password csv file into the dictionary,
        /// </summary>
        private void LoadPasswordDictionary()
        {
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                var values = line.Split(',');

                if (!passwordDictionary.ContainsKey(values[0]))
                {
                    passwordDictionary[values[0]] = values[1];
                }
                else
                {
                    Console.WriteLine($"Duplicate key found: {values[0]}. Skipping.");
                }
            }
        }

        /// <summary>
        /// validates if the given username and password pair exist in the dictionary.
        /// </summary>
        /// <param name="username">the username to be validated.</param>
        /// <param name="password">the password to be validated.</param>
        /// <returns></returns>
public bool Validate(string username, string password)
{
    Console.WriteLine($"Validating Username: {username}, Password: {password}");
    if (passwordDictionary.TryGetValue(username, out string storedPassword))
    {
        Console.WriteLine($"Stored Password: {storedPassword}");
        return storedPassword == password;
    }
    Console.WriteLine("Username not found.");
    return false;
}
    }
}
