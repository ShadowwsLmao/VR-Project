using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movetarget : MonoBehaviour
{
    public int speed = 5;
    public Vector3 vet;
    public bool facingRight = true;

    public Transform left;
    public Transform right;
    Vector3 leftV;
    Vector3 rightV;

    // Start is called before the first frame update
    void Start()
    {
        //leftV = new Vector3(left.transform.position.x, left.transform.position.y, left.transform.position.z);
        //rightV = new Vector3(right.transform.position.x, right.transform.position.y, right.transform.position.z);
        
    }

    // Update is called once per frame
    void Update()
    {
        leftV = new Vector3(left.transform.position.x, left.transform.position.y, left.transform.position.z);
        rightV = new Vector3(right.transform.position.x, right.transform.position.y, right.transform.position.z);
        Vector3 rot = new Vector3(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y + 180, transform.rotation.eulerAngles.z);
        vet = rot;
        if(facingRight == true)
        {
            transform.position = Vector3.Lerp(transform.position, rightV, Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, leftV, Time.deltaTime);
        }
        
        if(Vector3.Distance(transform.position, rightV) < 1)
        {
            facingRight = false;
        }
        if (Vector3.Distance(transform.position, leftV) < 1)
        {
            facingRight = true;
        }




        /*
        Vector3 vec = new Vector3(1, 1, 0);
        transform.Translate(Vector3.right * speed * Time.deltaTime);
        
        if(transform.position.x <= -3.0f && facingRight == false)
        {
            transform.rotation = Quaternion.Euler(rot);
            facingRight = true;
        }
        if (transform.position.x >= 3.0f && facingRight == true)
        {
            transform.rotation = Quaternion.Euler(rot);
            facingRight = false;
        }
        */
    }

void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Right"))
        {
            facingRight = false;
            Debug.Log("tagged");
        }
        if (other.gameObject.CompareTag("Left"))
        {
            facingRight = true;
        }
    }

}
