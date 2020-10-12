using System;
using System.Windows.Forms;

namespace InClassAssignment4
{
    public partial class InClassAssignment4 : Form
    {
        public InClassAssignment4()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Claculating Day,Hours, and Min from Seconds
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bttnFindOut_Click(object sender, EventArgs e)

        {
            //declaring variables
            int inputSeconds = Convert.ToInt32(txtElaspedSeconds.Text);
            int answerMinutes = 0;
            int answerHours = 0;
            int answerDays = 0;

            //Converting to Minutes
            if ((inputSeconds >= 60) & (inputSeconds < 3600))
            {
                answerMinutes = inputSeconds / 60;
                lblOutput.Text = "The number of minutes = " + answerMinutes;
            }

            //convert to hours
            else if ((inputSeconds >= 3600) & (inputSeconds < 86400))
            {
                answerHours = inputSeconds / 3600;
                lblOutput.Text = "The number of hours = " + answerHours;
            }

            //Convert to days
            else if (inputSeconds >= 86400)
            {
                answerDays = inputSeconds / 86400;
                lblOutput.Text = "The number of days = " + answerDays;

            }


        }

        private void InClassAssignment4_Load(object sender, EventArgs e)
        {
        }
    }
}


       
    

