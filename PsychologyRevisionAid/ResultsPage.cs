using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PsychologyRevisionAid
{
    public partial class ResultsPage : Form
    {
        private int ScoreResults;
        private string Category;
        
        public ResultsPage(int Score, string SelectedCategory)
        {
            // constructor
            // Stores quiz results(score) and topic quiz is on
            InitializeComponent();
            this.ScoreResults=Score;
            this.Category = SelectedCategory;
            lblTopic.Text = Category;
            lblScore.Text= Score.ToString();

            // Depending on the score,the mastery level is either low, okay or good
            if (ScoreResults == 0 || ScoreResults <= 5)
            {
                lblMastery.Text = " Low ";
            }
            else if (ScoreResults == 6 && ScoreResults <= 11)
            {
                lblMastery.Text = "  Okay ";
            }
            else if (ScoreResults == 12 && ScoreResults <= 15)
            {
                lblMastery.Text = "  Good ";
            }
        }
        private void btnProgressAnalysis_Click(object sender, EventArgs e)
        {
            //event procedure that displays Progress Analysis page when the Progresss button is clicked
            Progress ProgressAnalysis = new Progress(); // an object is instantiated from the Progress class (form)
            ProgressAnalysis.ShowDialog(); //Shows Progress form
            ProgressAnalysis.Close(); //Closes this form object

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
