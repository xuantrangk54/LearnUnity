using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class Line : MonoBehaviour
{
    public float moveSpeed;
    private float xDirection;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        this.xDirection = Input.GetAxisRaw("Horizontal");
        if ((transform.position.x<=-8 && xDirection<0) || (transform.position.x>=8 && xDirection>0)) return;
        transform.position+=new Vector3(moveSpeed*xDirection*Time.deltaTime,0,0);
    }

}
