using System;
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
            string[] responses = new string[20];
            responses[0] = textBox1.Text;
            responses[1] = textBox2.Text;
            responses[2] = textBox3.Text;
            responses[3] = textBox4.Text;
            responses[4] = textBox5.Text;
            responses[5] = textBox6.Text;
            responses[6] = textBox7.Text;
            responses[7] = textBox8.Text;
            responses[8] = textBox9.Text;
            responses[9] = textBox10.Text;
            responses[10] = textBox11.Text;
            responses[11] = textBox12.Text;
            responses[12] = textBox13.Text;
            responses[13] = textBox14.Text;
            responses[14] = textBox15.Text;
            responses[15] = textBox16.Text;
            responses[16] = textBox17.Text;
            responses[17] = textBox18.Text;
            responses[18] = textBox19.Text;
            responses[19] = textBox20.Text;


            SaveResponsesToCSV(responses);


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
