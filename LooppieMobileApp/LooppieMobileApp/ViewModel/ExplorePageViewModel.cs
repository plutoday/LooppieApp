using LooppieMobileApp.Model;
using LooppieMobileApp.Service;
using System;
using System.Collections.Generic;
using System.Text;

namespace LooppieMobileApp.ViewModel
{
    public class ExplorePageViewModel
    {
        public List<Question> Questions { get; set; }

        public ExplorePageViewModel()
        {
            Questions = QuestionGenerator.CreateQuestions();

        }
    }
}
