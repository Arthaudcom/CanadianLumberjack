using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;

public class Metamorphose : MonoBehaviour
{
    public GameObject log;
    public GameObject axe;
    public GameObject logCut;
    private bool sliced = false;
    public Score scoreScript;
    public ProgressBarFire progressBar;
    public List<AudioClip> chopList;
    public AudioSource cameraAudioSource;
    public GameObject rightController;
    public GameObject leftController;
    

    // Start is called before the first frame update
    void Start()
    {
        scoreScript = GameObject.FindGameObjectWithTag("GameManagerTag").GetComponent<Score>();
        progressBar = GameObject.FindGameObjectWithTag("GameManagerTag").GetComponent<ProgressBarFire>();
        cameraAudioSource = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<AudioSource>();
        rightController = GameObject.FindGameObjectWithTag("RightHand");
        leftController = GameObject.FindGameObjectWithTag("LeftHand");
    }
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Slice" && !sliced)
        {

            GameObject hache = collision.gameObject.GetComponent<GameObject>();

            //ActionBasedController controller = 

            scoreScript.addScore();
            progressBar.addValue();

            if (collision.gameObject.GetComponent<DifferenciateHand>().heldIn == "left")
            {
                leftController.GetComponent<ActionBasedController>().SendHapticImpulse(1, 0.5f);
            } else
            {
                rightController.GetComponent<ActionBasedController>().SendHapticImpulse(1, 0.5f);
            }


            int index = UnityEngine.Random.Range(0, chopList.Count);
            AudioClip chop = chopList[index];
            cameraAudioSource.PlayOneShot(chop);


            Vector3 posLog = gameObject.transform.position;

            sliced = true;


            Destroy(this.gameObject);
            GameObject cut1 = Instantiate(logCut, posLog, Quaternion.identity);
            GameObject cut2 = Instantiate(logCut, posLog, Quaternion.identity);

            cut2.GetComponent<Rigidbody>().AddForce(50 * (new Vector3(- 1, - 1, - 1)));
            cut1.GetComponent<Rigidbody>().AddForce(50 * (new Vector3(1,  1, - 1)));

            //cut1.GetComponent<Rigidbody>().AddForce(50*(new Vector3(Math.Abs(velocity.x)+1, velocity.y+1, -velocity.z-1)));
            //cut2.GetComponent<Rigidbody>().AddForce(50*(new Vector3(-Math.Abs(velocity.x)-1, -velocity.y-1, -velocity.z-1)));

            //gameObject.GetComponent<Rigidbody>().AddForce(/*0, 0, 500*/-10*(collision.gameObject.GetComponent<Rigidbody>().velocity));


            
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
