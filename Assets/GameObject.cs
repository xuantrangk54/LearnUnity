using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("This is the first time i learn Unity");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log($"DeltaTime is: {Time.deltaTime}");
    }
}
