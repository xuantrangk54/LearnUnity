using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text scoreText;
    public GameObject gameOverPanel;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
    public void SetScoreText(string txt)
    {
        if (this.scoreText) this.scoreText.text = txt;
    }
    public void ShowGameOverPanel (bool isShow)
    {
        if (this.gameOverPanel) this.gameOverPanel.SetActive(isShow);
    }

}
