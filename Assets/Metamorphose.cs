using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metamorphose : MonoBehaviour
{
    public GameObject log;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.gameObject == log)
        {
            Debug.Log("HIT");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
