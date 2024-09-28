using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Newtonsoft.Json;


[System.Serializable]
public class QuestionRepo
{
    [JsonProperty("questions")]
    public List<Question> Questions { get; set; }

    [System.Serializable]

    public class Question
    {
        [JsonProperty("question")]
        public string question { get; set; }
        [JsonProperty("answers")]
        public List<string> answers { get; set; }
        [JsonProperty("correctAnswer")]
        public int correctAnswer { get; set; }
    }
}
