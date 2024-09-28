using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    GameController gameController;

    // Start is called before the first frame update
    void Start()
    {
        this.gameController = FindObjectOfType<GameController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D col)
    {
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            this.gameController.IncrementScore();
        } 
    }
    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            if (gameController)
            {
                this.gameController.SetGameOver(true);
            }
            Destroy(this.gameObject);
        }
    }
}
