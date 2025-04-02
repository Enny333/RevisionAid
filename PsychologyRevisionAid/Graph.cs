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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PsychologyRevisionAid
{
    public partial class Graph : Form

    {
        private string CurrentTopi;
        private List<PrevQuizInfo> PreviousQuiz = new List<PrevQuizInfo>();
        public Graph(string topic)
        {
            this.CurrentTopi = topic; //Stores topic user selected to see progress analysis on
            InitializeComponent();
            ReadCSVfile();
            DrawChart();
            //costructor
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
           // try // error handling used when reading in from CSV file
                TextReader TeextFile = new StreamReader(getPath("Linegraph.csv"));
                string data;
                string[] QuizAttempt = new string[3];
                while ((data = TeextFile.ReadLine()) != null) // loop to reads file line by line unless it's empty
                {
                    QuizAttempt = data.Split(','); // splits csv file into topic and difficulty level
                    if (CurrentTopi == QuizAttempt[2]) //Ensures only the difficulty level for the topic the user is being quizzed on is selected
                    {
                        PreviousQuiz.Add(new PrevQuizInfo(Convert.ToString(QuizAttempt[0]), QuizAttempt[1], QuizAttempt[2])); //Stores csv file in list  
                      }
                }
                TeextFile.Close(); //Closes csv file

         List<PrevQuizInfo> temp = new List<PrevQuizInfo>();
                for (int i = PreviousQuiz.Count - 5; i < PreviousQuiz.Count; i++) //loops through last 5 quiz attempts and adds them to the list temp
                {
                    temp.Add(PreviousQuiz[i]);
                }
                PreviousQuiz = temp;
          }
            private void DrawChart()
            {
            //The purpose of this procedure is to display a line chart showing the progress of scores on the topic the user selected
            LineGraph.Series.Clear();
            LineGraph.Titles.Add("Scores for a Topic over time"); //Title of line graph
            Series s = new Series();
            int i = 0;
            foreach (PrevQuizInfo p in PreviousQuiz) //Loops through list who holds last 5 attempts
            {
                s.Points.AddXY(p.GetDate(), Convert.ToInt16(p.GetScore())); // Displays last 5 attempts with x showing date and y showing score the user got
                s.Points[i].AxisLabel = p.GetDate();
                i++;
            }
            s.ChartType = SeriesChartType.Line;
            s.Name = "Scores";
            LineGraph.Series.Add(s);
            
            }

    }
}
       

    
