using System;
using System.IO;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.UI;

public class QuizManager : MonoBehaviour
{
    public QuestionRepo itemList;
    private int currentQuestionIndex;
    public Text questionText;
    public Button[] optionButtons;


    void Start()
    {
        LoadData();
    }

    void LoadData()
    {
        string path = Path.Combine(Application.streamingAssetsPath, "data.json");

        if (File.Exists(path))
        {
            string json = File.ReadAllText(path);
            try
            {
                itemList = JsonConvert.DeserializeObject<QuestionRepo>(json);
            }
            catch (Exception ex)
            {
                Debug.LogError(ex);
            }
            Debug.Log(itemList.Questions.Count);
            foreach (var item in itemList.Questions)
            {
                Debug.Log($"Name: {item.question}, correctAnswer: {item.question[item.correctAnswer].ToString()}");
            }
        }
        else
        {
            Debug.LogError("Cannot find file!");
        }
    }

    public void DisplayNewQuestion()
    {
        if (this.itemList.Questions.Count > 0)
        {
            this.currentQuestionIndex = UnityEngine.Random.Range(0, itemList.Questions.Count);
            var question = itemList.Questions[currentQuestionIndex];
            questionText.text = question.question;
            for (int i = 0; i < optionButtons.Length; i++)
            {
                optionButtons[i].GetComponentInChildren<Text>().text = question.answers[i];
                int optionIndex = i;
                optionButtons[i].onClick.AddListener(() => CheckAnswer(optionIndex));
                Debug.Log($"Setted button {i} with text: {question.answers[i]}");
            }
        }
    }

    void CheckAnswer(int selectedOptionIndex)
    {
        if (selectedOptionIndex == this.itemList.Questions[currentQuestionIndex].correctAnswer)
        {
            Debug.Log("Đúng!");
        }
        else
        {
            Debug.Log("Sai!");
        }

        // Sau khi chọn câu trả lời, hiển thị câu hỏi mới
        DisplayNewQuestion();
    }

}