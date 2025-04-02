using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PsychologyRevisionAid
{
    public partial class Bar : Form
    {
      List<string> topicNames = new List<string>() {"Memory", "Attachment", "Psychopathology", "Social Influence" , "Research Methods",
      "Approaches in Psychology", "Schizophrenia" , "Gender", "Relationships", "Issues and debates in Psychology","Biopsychology", "Forensic Psychology"};
      //stores all the topics the user could wish to see their progress on 
      List<int> averages = new List<int>(); //Creates list to store average for each topi
      List<string> abvtopicNames = new List<string>() { "Memory", "Attachment", "Psychopathology", "SI", "RM", "Approaches", "Schizophrenia", "Gender", 
      "Relationships", "Debates", "Biopsychology", "Forensic" };
        


        private List<PrevQuizInfo> PreviousQuiz = new List<PrevQuizInfo>(); //List that stores previous quiz attempts
        
        public Bar()
        {
            InitializeComponent();           
            //Constructor
            ReadCSVfile();
            DrawChart();
        }
     
        private void DrawChart()
        {
            // The purpose of this procedure is to display a bar chart showing average scores across all the Psychology A-Level topics
            chart1.Series.Clear();
            chart1.Titles.Add("Scores for a Topic over time"); //Title of bar chart
            Series s = new Series();
            int i = 0;
            foreach (string t in abvtopicNames)//Loops through topicNames and uses i to find corresponding topic average
            {
                s.Points.AddXY(t, averages[i]); //Displays the topic on the x axis and displays the average score on the y axis
                s.Points[i].AxisLabel = t;
                i++;
            }
            s.ChartType = SeriesChartType.Column;
            s.Name = "Averages";
            chart1.Series.Add(s);
        }
        private string getPath(string fileNam)
        {
            //Accesses csv holding diffculity level and topic
            string filepath = Directory.GetCurrentDirectory();
            string Path = filepath + @"\" + fileNam;
            return Path;
        }
        private void ReadCSVfile()
        {
            // Read all the attempts stored in Linegraph csv and store them in a list
            TextReader TeextFile = new StreamReader(getPath("Linegraph.csv"));
            string data;
            string[] QuizAttempt = new string[3];
            while ((data = TeextFile.ReadLine()) != null) // loop to reads file line by line unless it's empty
            {
                QuizAttempt = data.Split(','); // splits csv file into topic and difficulty level

                 PreviousQuiz.Add(new PrevQuizInfo(Convert.ToString(QuizAttempt[0]), QuizAttempt[1], QuizAttempt[2]));  //Stores csv file in list         

            }

            TeextFile.Close(); //Closes csv file
            CalculateAverages(); //Calls subroutine so the average for each topic can be calclated
        }

        private void CalculateAverages()
        {
            //Calulates score average for each topic
            int[] totals = new int[topicNames.Count]; //Created to add all scores for all topics
            int[] counts = new int[topicNames.Count]; // Created to count how manys scores there are so knows how many to divide it by for the avg

            //for (int i = 0; i < PreviousQuiz.Count; i++)
            //{
            //    int locationOfTopicInAllTopics = topicNames.IndexOf(PreviousQuiz[i].GetTopic()); //Find where in 'topicNames' topic of the quiz attempt is so it can store it
            //    totals[locationOfTopicInAllTopics] += Convert.ToInt32(PreviousQuiz[i].GetScore()); //Using location add to score for that topic 
            //    counts[locationOfTopicInAllTopics] += 1; //Add one to attempt of that topic
            //}

            foreach (PrevQuizInfo p in PreviousQuiz) //loops through every single quiz attempt
            {
                int locationOfTopicInAllTopics = topicNames.IndexOf(p.GetTopic()); //Find where in 'topicNames' topic of the quiz attempt is so it can store it
                totals[locationOfTopicInAllTopics] += Convert.ToInt32(p.GetScore()); //Using location add to score for that topic 
                counts[locationOfTopicInAllTopics] += 1; //Add one to attempt of that topic
            }
            for (int i = 0; i < topicNames.Count; i++) //Loop though every topic 
            {
                averages.Add(totals[i] / counts[i]); // Work out avg of each topic and add to average list which is in same order as topic Names
            }
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
