using UnityEngine;

public class GameController : MonoBehaviour
{

    public GameObject ball;
    public float spawmTime;

    private UIManager uIManager;
    private float m_spawmTimeLeft;
    private int m_score;
    private bool m_isGameOver;

    // Start is called before the first frame update
    void Start()
    {
        this.m_spawmTimeLeft = 0;
        this.uIManager = FindObjectOfType<UIManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!this.m_isGameOver)
        {
            m_spawmTimeLeft -= Time.deltaTime;
            if (m_spawmTimeLeft <= 0)
            {
                this.SpawnBall();
                this.m_spawmTimeLeft = this.spawmTime;
            }
        }
        else
        {
            this.m_spawmTimeLeft = 0;
            this.uIManager.ShowGameOverPanel(true);
        }
    }

    public void SetSocre(int value) => m_score = value;
    public int GetScore() => this.m_score;
    public void IncrementScore()
    {
        m_score++;
        this.uIManager.SetScoreText($"Score: {this.m_score}");
    }
    public void SetGameOver(bool state) => this.m_isGameOver = state;
    public bool GetGameOverSate() => this.m_isGameOver;

    public void SpawnBall ()
    {
        Vector2 spwanPos = new Vector2(Random.Range(-7, 7), 6);
        if (ball)
        {
            Instantiate(ball, spwanPos, Quaternion.identity);
        }
    }

}
