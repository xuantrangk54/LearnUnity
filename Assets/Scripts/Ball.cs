using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("START OF BALL");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D (Collision2D col)
    {
        Debug.Log("VA CHAM");
        if (col.gameObject.CompareTag("Player"))
        {
            Debug.Log("HAVE DIEM");
        } else if (col.gameObject.CompareTag("DeathZone"))
        {
            Debug.Log("DIE");
        }
    }
    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            Debug.Log("DIE");
        }
    }
}
