using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metamorphose : MonoBehaviour
{
    public GameObject log;
    public GameObject logCut;
    private bool sliced = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Slice" && !sliced)
        {
            Debug.Log("HIT");
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 posLog = gameObject.transform.position;

            sliced = true;

            Vector3 velocity = gameObject.GetComponent<Rigidbody>().velocity;


			
            Destroy(this.gameObject);
            GameObject cut1 = Instantiate(logCut, posLog, Quaternion.identity);
            GameObject cut2 = Instantiate(logCut, posLog, Quaternion.identity);

            cut1.GetComponent<Rigidbody>().AddForce(new Vector3(-velocity.x, -velocity.y, velocity.z));
            cut2.GetComponent<Rigidbody>().AddForce(new Vector3(-velocity.x, -velocity.y, velocity.z));

            Debug.Log(rb.angularVelocity);

            //gameObject.GetComponent<Rigidbody>().AddForce(/*0, 0, 500*/-10*(collision.gameObject.GetComponent<Rigidbody>().velocity));
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
