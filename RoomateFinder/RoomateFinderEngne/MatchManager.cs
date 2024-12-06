using System;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace RoomateFinderEngne
{
    public class MatchManager
    {
        private string firsName, lastName;
        private RoomateFinderController controller;

        /// <summary>
        /// Initializes a new instance of the <see cref="MatchManager"/> class.
        /// Takes a controller and opens a CSV file to read matches.
        /// </summary>
        /// <param name="controller">The controller to interact with for managing matches.</param>
        public MatchManager(RoomateFinderController controller)
        {
            this.controller = controller;
        }

        /// <summary>
        /// Reads match data from the CSV file and adds matches to the controller.
        /// </summary>
        public void FindMatches()
        {
            string filePath = "matches.csv";

            if (!File.Exists(filePath))
            {
                Console.WriteLine($"File not found at: {Path.GetFullPath(filePath)}");
                return;
            }

            Console.WriteLine($"Reading matches from {filePath}");

            using (var reader = new StreamReader(filePath))
            {
                int lineNumber = 0;

                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    lineNumber++;

                    if (string.IsNullOrWhiteSpace(line))
                    {
                        Console.WriteLine($"Skipping empty line {lineNumber}");
                        continue;
                    }

                    var values = line.Split(',');

                    if (values.Length >= 3)
                    {
                        string username = values[0].Trim();
                        string firstName = values[1].Trim();
                        string lastName = values[2].Trim();

                        if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName))
                        {
                            Console.WriteLine($"Invalid data at line {lineNumber}: {line}");
                            continue;
                        }

                        var match = new Match(username, firstName, lastName);

                        Console.WriteLine($"Parsed match: {match}");
                        controller.AddMatch(match);
                    }
                    else
                    {
                        Console.WriteLine($"Invalid format at line {lineNumber}: {line}");
                    }
                }
            }
        }


        public void SaveMatches()
        {
            using (StreamWriter writer = new StreamWriter("matches.csv"))
            {
                foreach (var match in controller.matches)
                {
                    writer.WriteLine(match);
                }
            }
        }
    }
}