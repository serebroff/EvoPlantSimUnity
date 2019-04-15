using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SunBehaviour : MonoBehaviour
{
    public Transform  tr;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I am alive!");
        tr = GetComponent<Transform>();
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 pos = transform.position;
        pos.x += 0.1f;
        transform.position = pos;
                

    }
}
