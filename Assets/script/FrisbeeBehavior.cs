using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrisbeeBehavior : MonoBehaviour
{
    private Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
       startingPos = transform.position; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Pin") || collision.gameObject.CompareTag("Ground"))
        {
            transform.position = startingPos;
        }
    }

    void CheckPosition()
    {
        if (transform.position.y <= -1)
        {
            transform.position = startingPos;
        }

    }
}
