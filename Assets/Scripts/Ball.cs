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
        if (col.gameObject.CompareTag("Player"))
        {
            Destroy(this.gameObject);
            Debug.Log("HAVE DIEM");
        } 
    }
    private void OnTriggerEnter2D (Collider2D col)
    {
        if (col.CompareTag("DeathZone"))
        {
            Debug.Log("DIE");
            Destroy(this.gameObject);
        }
    }
}
