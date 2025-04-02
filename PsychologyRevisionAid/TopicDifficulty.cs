using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace PsychologyRevisionAid
{
    internal class TopicDifficulty
    {
        private string topic;
        private int level;
        //Constructor for topic and level
        public TopicDifficulty( string newtopic, int newlevel) 
        {
            this.level = newlevel;
            this.topic = newtopic;
           
        }
        public string Gettopic() { return topic; } // getter for topic
        public int Getlevel() { return level; } //getter for level
       
        
        private void SetLevel(int plevel) //setter for difficulty level
        {
            level = plevel;
        } 
    }
}
