using PsychologyRevisionAid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace PsychologyRevisionAid
{
    public partial class QuesionsAndAnswers : Form
    {
        private List<TopicDifficulty> TopicAndLevel = new List<TopicDifficulty>();
        private string SelectedCategory;
        private List<Question> QuestionsList = new List<Question>();
        private Question selectedQuestion;
        private TopicDifficulty selectedTopicDifficulty;
        private int QuestionNumber = 1;
        private string selectedAnswer;
        private RadioButton selectedRadio;
        private RadioButton selectedButton;
        private int Score = 0;
        private int incorrect = 0;
        private int Correct = 0;
        private int difficulty;
        private int newIndex;
        private int difficultylevelupdate;
        private int newindex;
        

        public QuesionsAndAnswers(string category)
        {
            InitializeComponent(); // Draws components
            this.SelectedCategory = category;
            ReadQuestions();
            ReadDifficulty();
            Changedifficulty();
            SelectQuestion();
            AskQuestion();
            lblTopic.Text = category;
            btnCheckAnswer.Enabled = false;
            btnNextQ.Enabled = false;
            lblRightOutOfAmountOfQuestions.Text = "0";
            btnResults.Enabled = false;
        }
        private string getPath(string fileName)
        {
            //function to identify the path of csv file containing psychology topic,questions and answers
            string path = Directory.GetCurrentDirectory();
            string FileName = path + @"\" + fileName;
            return fileName;
        }

        private void ReadQuestions()
        {
            // Procedure that read all questions that match the selected topic from the CSV file and add to a list called 'QuestionsList' 

            try // error handling used when reading in from CSV file
            {
                TextReader TextFile = new StreamReader(getPath("Questions2.csv"));
                string Data;

                string[] QuestionsData = new string[4];
                while ((Data = TextFile.ReadLine()) != null) // loop to reads file line by line unless it's empty
                {
                    QuestionsData = Data.Split(','); //Splits data in csv file into tables:Question,Answers,Topic,Difficulty level

                    if (SelectedCategory == QuestionsData[2]) //If ststament ensures List only stores questions and answers from the topic selected by the user
                    {
                        QuestionsList.Add(new Question(QuestionsData[0], QuestionsData[1], QuestionsData[2], Convert.ToInt32(QuestionsData[3])));
                    }
                }
                TextFile.Close(); //Closes csv file
            }
            //Display error messsage and takes user to another page if error occurs
            catch (Exception)
            {
                MessageBox.Show("File cannot be found");
                NotFound ToFile = new NotFound();
                ToFile.ShowDialog();
                ToFile.Close();
            }
        }
        private void Changedifficulty()
        {
            //procedure to get current difficulty level
            selectedTopicDifficulty = TopicAndLevel[newindex];
            difficultylevelupdate = selectedTopicDifficulty.Getlevel();
            difficulty = difficultylevelupdate;
        }
        private void SelectQuestion()
        {
            //select a random question from the list with the correct difficult level
            do //loop to generate questions until the question level equals user's current difficulty level
            {
                Random rand = new Random();
                newIndex = rand.Next(0, QuestionsList.Count);
                selectedQuestion = QuestionsList[newIndex];//Stores the random number generated as an select a question from the list
            } while (selectedQuestion.getLevel() != difficulty);

            QuestionsList.RemoveAt(newIndex); //question is removed from the list so it can't be asked again
        }
        private void AskQuestion()
        {
            //Procedure to display randomly seleccted question and its difficulty level to user, check the answer, update and display question number

            lblQNumber.Text = QuestionNumber.ToString() + ". "; //displays question number
            lblQuestion.Text = selectedQuestion.getQuestion(); // displays randomly selected question in label 'lblQuestion'
            AnswersOpts(); //Calls the procedure AnswerOpts()
            QuestionNumber++; //increments question number
            lblDiffLevel.Text = selectedQuestion.getLevel().ToString(); //displays difficulty level of question in label 'lblDiffLevel'
        }

        private void AnswersOpts()
        { //Procedure to randomly select answers from the answer field in the csv file and display them as answer options so the user can select an answer after a question
          //is displayed

            string[] possAnswers = new string[4];
            possAnswers[0] = selectedQuestion.getAnswer(); //Stores correct answer for the question in index 0 of array 'possAnswers'
            Random rand = new Random();
            for (int i = 1; i <= 3; i++)
            {
                //For loop ensures only 3 wrong answers are randomly generated (for answer field in list) to be stored in the radio buttons as options for the user to select
                string Answer = null;
                bool match = true;

                while (match)
                { //while loop to ensure 3 suitable answer options are stored in possAnswers
                    match = false;
                    int newIndex = rand.Next(0, QuestionsList.Count);
                    Answer = QuestionsList[newIndex].getAnswer();
                    for (int j = 0; j < possAnswers.Length; j++) // for loop to loop through 'possAnswers' array and check to see if any items match
                        if (Answer == possAnswers[j])  // The if statement ensures if a value generated is already in the array, answers keep being generated to stored in the array
                        {
                            match = true;
                        }
                }
                possAnswers[i] = Answer; //Assigns new answer option to the next index
            }
            ShuffleAnswers(ref possAnswers); //Calls procedure so answer options can be shuffled/mixed

            //Displays answer options in radio buttons
            // here you have the correct answer + 3 fake answers in possAnswers
            btnOpt1.Text = possAnswers[0].ToString();
            btnOpt2.Text = possAnswers[1];
            btnOpt3.Text = possAnswers[2];
            btnOpt4.Text = possAnswers[3];

            //If the radio button selected matches the correct answer for the question, store the button in the varaible selectedButton

            if (btnOpt1.Text == selectedQuestion.getAnswer())
            {
                selectedButton = btnOpt1;
            }
            if (btnOpt2.Text == selectedQuestion.getAnswer())
            {
                selectedButton = btnOpt2;
            }
            if (btnOpt3.Text == selectedQuestion.getAnswer())
            {
                selectedButton = btnOpt3;
            }
            if (btnOpt4.Text == selectedQuestion.getAnswer())
            {
                selectedButton = btnOpt4;
            }
        }
        private void ShuffleAnswers(ref string[] possAnswers)
        {
            //procedure that rearranges the ordeer of the answer options
            Random rand = new Random();
            for (int i = 0; i < possAnswers.Length; i++) //for loop to shuffle the item in possAnswers
            {
                int j = rand.Next(0, possAnswers.Length);
                string temp = possAnswers[i];
                possAnswers[i] = possAnswers[j];
                possAnswers[j] = temp;
           }

        }
        private void MarkQ()
        {
            //Procedure to compare the user's answer to the correct and answer then highlight the radio options accordingly
            btnNextQ.Visible = true;
            if (selectedAnswer == selectedQuestion.getAnswer()) //if ststament to compare the button the user has selected with the correct answer
            {

                selectedRadio.ForeColor = Color.Green; //Turns the answer the user selected green if their answer matches the correct answer
                Score++; //Increments score by 1 since the user got the question right
                lblRightOutOfAmountOfQuestions.Text = Score.ToString(); //Updates score displayed
                Correct++; //Increments everytime the user gets an answer correct

            }
            if (selectedAnswer != selectedQuestion.getAnswer())  //If the answer the user selected doesn't equal the correct answer
            {
                lblRightOutOfAmountOfQuestions.Text = Score.ToString();  //the score displays remains the same
                selectedRadio.ForeColor = Color.Red; //Turns the answer the user has selected red
                selectedButton.ForeColor = Color.Green; //Turns the right answer green
                incorrect++; //Increments the number of questions the user has gotton wrong

            }
                btnNextQ.Enabled = true; //Enables the Next button so the user can be asked another question
        }
        private void CheckAnswerOpt1(object sender, EventArgs e)
        {// Event Procedure to store the button if selected as selectedAnswer and allow the user to check the answer if the radio button has been clicked
            btnCheckAnswer.Enabled = true;
            selectedAnswer = btnOpt1.Text;
            selectedRadio = btnOpt1;
        }
        private void CheckAnswerOpt2(object sender, EventArgs e)
        {//Procedure to store the button if selected as selectedAnswer and allow the user to check the answer if the radio button has been clicked
            btnCheckAnswer.Enabled = true;
            selectedAnswer = btnOpt2.Text;
            selectedRadio = btnOpt2;
        }

        private void CheckAnswerOpt3(object sender, EventArgs e)
        {
            //Procedure to store the button if selected as selectedAnswer and allow the user to check the answer if the radio button has been clicked
            btnCheckAnswer.Enabled = true;
            selectedAnswer = btnOpt3.Text;
            selectedRadio = btnOpt3;
        }
        private void CheckAnswerOpt4(object sender, EventArgs e)
        {  //Procedure to store the button if selected as selectedAnswer and allow the user to check the answer if the radio button has been clicked
            btnCheckAnswer.Enabled = true;
            selectedAnswer = btnOpt4.Text;
            selectedRadio = btnOpt4;
        }
        private void btnCorrect_Click(object sender, EventArgs e)
        {
            //When checkAnswe has been clicked, the subroutine is called to mark the user's answer
            MarkQ();
        }
        private void btnNext_Click(object sender, EventArgs e)
        {
            // event procedure that runs when the Next button has been clicked
            //Returns radio buttons colours to black once another question is displayed so the user wont know which answer is correct(it'd be green)
            btnOpt1.ForeColor = Color.Black;
            btnOpt2.ForeColor = Color.Black;
            btnOpt3.ForeColor = Color.Black;
            btnOpt4.ForeColor = Color.Black;


            if (Correct == 4 && difficulty <= 3) //If the user get 4 quetions in a row correct the diffculty level increases if it is below 3
            {
                difficulty++;
                Correct = 0;
            }
            else if (incorrect == 2 && difficulty > 1)  //If the user get 2 questions in a row incorrect the diffculty level decreases if it is above to 1
            {
                difficulty--;
                incorrect = 0;  

            }
            //If Question Number is 15 , Result button is enabled. If not, another question is selected then displayed.

            if (QuestionNumber <= 15)
            {
                SelectQuestion();
                AskQuestion();
            }
            else if (QuestionNumber > 15)
            {

                btnResults.Enabled = true;
                btnNextQ.Enabled = false;
                Overwritelevelsfile();
                AccessAndAddToCSV();
            }

        }
        private void btnResults_Click(object sender, EventArgs e)
        {
            //event procedure that displays Results page whent he Reults button is clciked
            ResultsPage Results = new ResultsPage(Score, SelectedCategory); // an object is instantiated from the ResultsPage class (form)
            Results.ShowDialog(); //Shows ResultsPage form
            Results.Close(); //Closes this form object
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            // event procedure that makes sure when the back button is clicked, the user returns to the MainMenue
            MainMenu ToMain = new MainMenu();
            ToMain.ShowDialog(); //Shows MainMenue form
            ToMain.Close(); //Closes this form object
        }
        private string GetPath(string fileNam)
        {
            //Accesses csv holding diffculity level and topic
            string filepath = Directory.GetCurrentDirectory();
            string Path = filepath + @"\" + fileNam;
            return Path;
        }

        private void ReadDifficulty()
        { // Procedure that read all the topics and levels from csv file and adds them to list 'TopicAndLevel'
            try // error handling used when reading in from CSV file
            {
                TextReader TxtFile = new StreamReader(getPath("Levels.csv"));
                string data;
                string[] DifficultyLevel = new string[2];
                while ((data = TxtFile.ReadLine()) != null) // loop to reads file line by line unless it's empty
                {
                    DifficultyLevel = data.Split(','); // splits csv file into topic and difficulty level
                    if (SelectedCategory == DifficultyLevel[0]) //Ensures only the difficulty level for the topic the user is being quizzed on is selected
                    {

                        TopicAndLevel.Add(new TopicDifficulty(DifficultyLevel[0], Convert.ToInt32(DifficultyLevel[1])));
                    }
                }
                TxtFile.Close(); //Closes csv file

            }
            catch (Exception) // Outputs error message and redirects user to a different page if there is an error with the csv file
            {
                MessageBox.Show("File cannot be found");
                NotFound ToFile = new NotFound(); // an object is instantiated from the NotFound class (form)
                ToFile.ShowDialog(); //Shows NotFound form
                ToFile.Close(); //Closes this form object

            }
        }
        private void Overwritelevelsfile()
        {
            // This procedure overwrites the difficulty level for a topic in the csv file with the current difficulty level the user ended the quiz on 
            List<string> levels = new List<string>(File.ReadAllLines("Levels.csv"));
            int row = -1;
            string[] column = new string[2];
            do //splits csv file into colums while the topic of the csv doesnt equal the topic selected by the user
            {
                row++;
                column = levels[row].Split(',');
            }
            while (column[0] != SelectedCategory);
            column[1] = difficulty.ToString();
            levels[row] = column[0] + "," + column[1];
            lblDiffLevel.Text = column[1];
            File.WriteAllLines("Levels.csv", levels); // overwrites the level field in csv file with current difficulty level
        }

        private void AccessAndAddToCSV()
        {
            //This subroutine accesses the CSV and adds the topic,date and score of the user's quiz to the csv file 
            string filePath = Directory.GetCurrentDirectory();
            string FileName = filePath + @"\Linegraph.csv";
            TextWriter TextF = new StreamWriter(FileName, true);
            TextF.WriteLine($"{Convert.ToString(Score)},{DateTime.Now.ToString("d")},{SelectedCategory}");
            TextF.Close();
        }
    }
}

