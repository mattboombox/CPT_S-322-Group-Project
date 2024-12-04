﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace RoomateFinder
{
    public partial class SurveyUI : Form
    {
        public SurveyUI()
        {
            InitializeComponent();
            
            answerTextBoxes = new TextBox[]
            {
                textBox1, textBox2, textBox3, textBox4, textBox5,
                textBox6, textBox7, textBox8, textBox9, textBox10,
                textBox11, textBox12, textBox13, textBox14, textBox15,
                textBox16, textBox17, textBox18, textBox19, textBox20
            };

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Gathering results from text boxes
            string response1 = textBox1.Text;
            string response2 = textBox2.Text;
            string response3 = textBox3.Text;
            string response4 = textBox4.Text;
            string response5 = textBox5.Text;
            string response6 = textBox6.Text;
            string response7 = textBox7.Text;
            string response8 = textBox8.Text;
            string response9 = textBox9.Text;
            string response10 = textBox10.Text;
            string response11 = textBox11.Text;
            string response12 = textBox12.Text;
            string response13 = textBox13.Text;
            string response14 = textBox14.Text;
            string response15 = textBox15.Text;
            string response16 = textBox16.Text;
            string response17 = textBox17.Text;
            string response18 = textBox18.Text;
            string response19 = textBox19.Text;
            string response20 = textBox20.Text;





            // Placeholder logic for processing the responses
            string message = "Survey Submitted Successfully!\n";

            MessageBox.Show(message);

            // Logic to save to csv file here

            // Close the form after submit
            this.Close();
        }
    

        private void SaveResponsesToCSV(string[] responses)
        {
            try
            {
                string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "UserSurveyResponses.csv");
                string responseLine = string.Join(",", responses);
        
                bool fileExists = File.Exists(filePath);

                using (StreamWriter sw = new StreamWriter(filePath, true))
                {
                    if (!fileExists)
                    {
                        sw.WriteLine("UserID,Responses");
                    }

                    string userId = Guid.NewGuid().ToString();

                    sw.WriteLine($"{userId},{responseLine}");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving survey responses: {ex.Message}");
            }
        }
    }
}
