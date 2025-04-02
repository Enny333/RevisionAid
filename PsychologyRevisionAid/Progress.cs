using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PsychologyRevisionAid
{
    public partial class Progress : Form
    {
        public Progress()
        {
            InitializeComponent();
        }


        private void btnGraph_Click(object sender, EventArgs e)
        {
            //event procedure that is triggered when the user selects 'Show Graph' button and displasy a table of the most frequently incorrectly answered questions
            if (comboBox1.SelectedIndex == -1)
            {
                //if statment that checks if the user has elected a topic from the list before they have clicked 'Show Graph'
                MessageBox.Show("Please select a topic", "Select Topic", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                //passing value of topic selected to graph so graph generated if based on topic 
                Graph ShowProgress = new Graph((string)comboBox1.SelectedItem);
                ShowProgress.ShowDialog();
                ShowProgress.Close();
            }
        }


        private void btnTable_Click(object sender, EventArgs e)
        {

        }

        private void btnBar_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Progress_Load(object sender, EventArgs e)
        {

        }
    }
}

    

