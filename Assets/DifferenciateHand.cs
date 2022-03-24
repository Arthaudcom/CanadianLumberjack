using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifferenciateHand : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "LeftHand") { Debug.Log("LeftHand : " + gameObject.name); }
        if(other.gameObject.tag == "RightHand") { Debug.Log("RightHand : " + gameObject.name); }
    }
}
