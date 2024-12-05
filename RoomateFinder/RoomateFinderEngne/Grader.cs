using System;
using System.Linq;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace RoommateFinderEngine
{

    //This class has two arrays, one for scores and another for storing the indecies of the top three highest scored roommate answers.
    //The score for the answers is done by comparing strings, incrementing by one when a character matches in a string.
    //The indicies stored in the matchIndicies is used to find the first and last names in the roommate.csv file
    public class Grader
    {
        public int[] scores;
        public int[] matchIndicies;
        public string userAnswers;
        public string filePath;

        public Grader(string UserSurveyResults, string FilePath)
        {
            // Array for storing scores from roommates.csv
            scores = new int[100];
            // Array for storing the indices of the top three scores
            matchIndicies = new int[3];

            filePath = FilePath;

            userAnswers = UserSurveyResults;
        }

        // Compares the answer string from the user and a roommate answer string, giving it a plus one score for each matching answer
        public int gradeAnswer(string roommateAnswers)
        {
            int minLength = Math.Min(userAnswers.Length, roommateAnswers.Length);
            int score = 0;

            for (int i = 0; i < minLength; i++)
            {
                if (userAnswers[i] == roommateAnswers[i])
                {
                    score++;
                }
            }

            return score;
        }

        // Stores a score into the grader classes score array
        public void buildScores(List<string> roommateAnswers)
        {
            for (int i = 0; i < roommateAnswers.Count; i++)
            {
                this.scores[i] = gradeAnswer(roommateAnswers[i]);
            }
        }

        // Sorts the scores from the scores array and stores their indices in the matchIndices array
        public void buildMatchIndexs()
        {
            // Create an array of score-index pairs, sort by score descending, and take top 3
            var topIndices = scores
                .Select((score, index) => new { Score = score, Index = index }) // Pair scores with their indices
                .OrderByDescending(pair => pair.Score) // Sort by score descending
                .Take(3) // Take the top 3 pairs
                .ToArray(); // Convert to array for easy access

            // Populate matchIndices with the indices of the top 3 scores
            for (int i = 0; i < topIndices.Length; i++)
            {
                matchIndicies[i] = topIndices[i].Index;
            }
        }

        // Reads the roommate answers from the CSV file
        public List<string> LoadAnswersFromFile()
        {
            var answers = new List<string>();

            try
            {
                // Ensure the file exists
                if (!File.Exists(filePath))
                {
                    Console.WriteLine($"File not found at path: {filePath}");
                    return answers;
                }

                // Open the file with FileStream and StreamReader
                using (StreamReader reader = new StreamReader(File.OpenRead(this.filePath)))
                {
                    string line;

                    // Read lines until the end of the file
                    while ((line = reader.ReadLine()) != null)
                    {
                        // Split each line by commas
                        var parts = line.Split(',');

                        // Ensure the line has exactly three parts
                        if (parts.Length == 3)
                        {
                            // Extract the answers string (third part of each line)
                            string answerString = parts[2].Trim();

                            // Add to the list
                            answers.Add(answerString);
                        }
                        else
                        {
                            Console.WriteLine($"Invalid line format: {line}");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error reading the file: {ex.Message}");
            }

            return answers;
        }

        //Runs all related class functions
        public void CalculateMatches()
        {
            // Load roommate answers from the CSV file
            List<string> roommateAnswers = LoadAnswersFromFile();

            // Fill the scores array using the loaded answers
            for (int i = 0; i < roommateAnswers.Count; i++)
            {
                this.scores[i] = gradeAnswer(roommateAnswers[i]);
            }

            // Determine the top matches and populate the matchIndicies array
            buildMatchIndexs();
        }
    }

    
}