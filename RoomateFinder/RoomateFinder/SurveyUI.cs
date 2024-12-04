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
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // placeholder logic for gathering results of questions

            MessageBox.Show("Survey Submitted Succesfully!");
        }
    }
}
