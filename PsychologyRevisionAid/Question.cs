using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyRevisionAid
{
   class Question
    {
        private string question; 
        private string answer;
        private string category;
        private int level;

        public Question(string newquestion, string newanswer, string newcategory, int newlevel)
        {
            this.question = newquestion; 
            this.answer = newanswer;    
            this.category = newcategory; 
            this.level = newlevel; 
        }

        //getters

        public string getQuestion() { return question; } // getter that returns a question
        public string getAnswer() { return answer; }     // getter for answer
        public string getCategory() { return category; } //getter for category
        public int getLevel() { return level; } //returns the difficulty level of the question
    }
}
