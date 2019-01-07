using System;
using System.Collections.Generic;
using System.Text;

namespace LooppieMobileApp.Model
{
    public class Question
    {
        public string QuestionDescription { get; set; }
        public Guid QuestionId { get; set; }
        public List<Answer> AnswerList { get; set; }
        public string Category { get; set; }
        public string SubCategory { get; set; }
        public List<int> Tags { get; set; }

    }
}
