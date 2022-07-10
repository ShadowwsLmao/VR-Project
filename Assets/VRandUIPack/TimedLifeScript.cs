using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimedLifeScript : MonoBehaviour
{
    [SerializeField] private float lifetime = 5;
    private float curLifetime = 0;
    [SerializeField] private bool destructive = false;

    private void Awake()
    {
        curLifetime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        curLifetime += Time.deltaTime;
        if (curLifetime >= lifetime)
            if (destructive)
                Destroy(gameObject);
            else
                gameObject.SetActive(false);
    }
}
