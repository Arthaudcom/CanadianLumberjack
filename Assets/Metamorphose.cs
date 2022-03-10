using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metamorphose : MonoBehaviour
{
    public GameObject log;
    public GameObject logCut;
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
            Vector3 posLog = gameObject.transform.position;

			gameObject.GetComponent<BoxCollider>().
			
            Destroy(this.gameObject);
            Instantiate(logCut, posLog, Quaternion.identity);
            Instantiate(logCut, posLog, Quaternion.identity);

            Debug.Log(rb.angularVelocity);

            //gameObject.GetComponent<Rigidbody>().AddForce(/*0, 0, 500*/-10*(collision.gameObject.GetComponent<Rigidbody>().velocity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
