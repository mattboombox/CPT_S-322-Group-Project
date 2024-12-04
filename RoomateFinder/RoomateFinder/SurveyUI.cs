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
            string[] responses = new string[answerTextBoxes.Length];
            for (int i = 0; i < answerTextBoxes.Length; i++)
            {
                if (string.IsNullOrWhiteSpace(answerTextBoxes[i].Text))
                {
                    MessageBox.Show($"Please answer question {i + 1}.");
                    return;
                }
                responses[i] = answerTextBoxes[i].Text.Trim();
            }
            MessageBox.Show("Survey Submitted Successfully!");

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
