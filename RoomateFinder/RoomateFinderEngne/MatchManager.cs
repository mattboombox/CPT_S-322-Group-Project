using System;
using System.ComponentModel;
using System.IO;
using System.Diagnostics;

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
public void findMatches()
{
    if (!File.Exists("matches.csv"))
    {
        return;
    }

   // StreamReader reader = new StreamReader(@"C:\Users\katiebrickner\Desktop\CPT_S-322-Group-Project\RoomateFinder\RoomateFinderEngne\matches.csv");
    string filePath = "matches.csv";

 using (StreamReader reader = new StreamReader(filePath))
        {
            int lineNumber = 0;

            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                lineNumber++;
                var values = line.Split(',');

                if (values.Length >= 2)
                {
                    string firstName = values[0].Trim();
                    string lastName = values[1].Trim();

                    // Create a new Match object
                    Match match = new Match(firstName, lastName);

                    // Add the match to the controller
                    controller.AddMatch(match);
                }   
            }
         }
        }
    }
}