using LooppieMobileApp.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace LooppieMobileApp.Service
{
    public class QuestionGenerator
    {
        public static List<Question> CreateQuestions()
        {
            // get response
            string url = "http://168.156.46.11:44328/questions";
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri(url);
            try
            {
                var response = client.GetAsync(client.BaseAddress).Result;
                response.EnsureSuccessStatusCode();

                // deserialize
                var jsonResult = response.Content.ReadAsStringAsync().Result;
                var questions = JsonConvert.DeserializeObject<List<Question>>(jsonResult);

                return questions;
            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                throw e;
            }


        }
    }
}
