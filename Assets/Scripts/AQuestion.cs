using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public interface GenerateQuestion {
    public ExampPage Generate(GenerateQuestionSetting generateQuestionSetting)
    {
        return new ExampPage()
        {
            LimitTimeSeconds = 5,
            MinScoreToPass = 10,
            Questions = new List<AQuestion>(){
                new AQuestion(){
                    IntroText="",
                    Question="Which of the following dishes is spicy?",
                    QuestionAudioPath="/abc.mp3",
                    AnswerId=1,
                    Answers=new List<AQuestion.Answer>()
                    {
                        new AQuestion.Answer()
                        {

                        },
                        new AQuestion.Answer()
                        {

                        },
                        new AQuestion.Answer()
                        {

                        },
                        new AQuestion.Answer()
                        {

                        }
                    }
                }
            }
        };
    }
}

public class GenerateQuestionSetting {
    public int Type {get;set;}
}

public class ExampPage {
    public List<AQuestion> Questions {get;set;}
    public int LimitTimeSeconds {get;set;}
    public int MinScoreToPass {get;set;}
}


public class AQuestion
{
    public string IntroText { get; set; }
    public string Question { get; set; }
    public string QuestionAudioPath { get; set; }
    public int AnswerId { get; set; }
    public List<Answer> Answers { get; set; }

    public class Answer
    {
        public string ImagePath { get; set; }
        public string Text { get; set; }
        public string AudioPath { get; set; }
        public int Id { get; set; }
    }
}
