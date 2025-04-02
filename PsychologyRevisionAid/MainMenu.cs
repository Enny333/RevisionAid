using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PsychologyRevisionAid
{
    public partial class MainMenu : Form
    {
        public string SelectedCategory;       
        public MainMenu()
        {// constructor
            InitializeComponent(); // draws components
            btnStart.Enabled = false;
        }
        private void TopicSelected(object sender, EventArgs e)
        {
            // Procedure to get value from list and make it equal SelectedCategory            
            SelectedCategory = lstBox.SelectedItem.ToString();
            btnStart.Enabled = true; //Enables start button
        }
        private void StartButtonClick(object sender, EventArgs e)
        {
            //Creates Questions and Answers form(passes selected topic/category in)
            //Closes current MainMenu form
            // Procedure to open questions and answers menu only when a topic is selected by the user

            QuesionsAndAnswers newQuestion = new QuesionsAndAnswers(SelectedCategory); // an object is instantiated from the Questions and Answers class (form)
            newQuestion.ShowDialog(); //Shows QuestionsAndAnswers form
            newQuestion.Close(); //Closes this form object
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            Bar ShowProgress = new Bar();
            ShowProgress.ShowDialog();
            ShowProgress.Close();
        }
    }
}
