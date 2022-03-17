using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class Metamorphose : MonoBehaviour
{
    public GameObject log;
    public GameObject axe;
    public GameObject logCut;
    private bool sliced = false;
    public Score scoreScript;

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("GameManagerTag").GetComponent<Score>();
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Slice" && !sliced)
        {

            scoreScript.addScore();

            Debug.Log("HIT");
            Rigidbody rb = collision.gameObject.GetComponent<Rigidbody>();
            Vector3 posLog = gameObject.transform.position;

            sliced = true;

            Vector3 velocity = axe.GetComponent<Rigidbody>().velocity;

            Debug.Log(velocity);


            Destroy(this.gameObject);
            GameObject cut1 = Instantiate(logCut, posLog, Quaternion.identity);
            GameObject cut2 = Instantiate(logCut, posLog, Quaternion.identity);

            cut1.GetComponent<Rigidbody>().AddForce(50 * (new Vector3(velocity.x + 1, velocity.y + 1, velocity.z - 1)));
            cut2.GetComponent<Rigidbody>().AddForce(50 * (new Vector3(velocity.x - 1, velocity.y - 1, velocity.z - 1)));

            //cut1.GetComponent<Rigidbody>().AddForce(50*(new Vector3(Math.Abs(velocity.x)+1, velocity.y+1, -velocity.z-1)));
            //cut2.GetComponent<Rigidbody>().AddForce(50*(new Vector3(-Math.Abs(velocity.x)-1, -velocity.y-1, -velocity.z-1)));

            Debug.Log(rb.angularVelocity);

            //gameObject.GetComponent<Rigidbody>().AddForce(/*0, 0, 500*/-10*(collision.gameObject.GetComponent<Rigidbody>().velocity));


            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
