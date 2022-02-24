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
        if (collision.gameObject.tag == "Slice")
        {
            Debug.Log("HIT");
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Debug.Log(rb.angularVelocity);
            SteamVR
            gameObject.GetComponent<Rigidbody>().AddForce(/*0, 0, 500*/-10*(collision.gameObject.GetComponent<Rigidbody>().velocity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
