using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyRevisionAid
{
    class PrevQuizInfo
    {
        private string Score;
        private string Date;
        private string Topic;

        public PrevQuizInfo(string score, string date, string topic)
        {
            this.Score = score;
            this.Date = date;
            this.Topic = topic;
            //constructor
        }

        public string GetScore() { return Score; }
        public string GetDate() { return Date; }
        public string GetTopic() { return Topic; }

    }
}
