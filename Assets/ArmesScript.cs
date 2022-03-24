using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmesScript : MonoBehaviour
{
    public List<GameObject> currentArme;
    public GameObject tronc_fab;
    public Transform camPos;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void deleteArmes()
    {
        foreach(GameObject arme in currentArme)
        {
            Destroy(arme);
            currentArme.Remove(arme);
        }
    }
    public void newArme()

    
    {
        GameObject tronconeuse = Instantiate(tronc_fab, new Vector3(133, 0.5f, 81), Quaternion.identity);
            currentArme.Add(tronconeuse);
            Rigidbody rb = tronconeuse.GetComponent<Rigidbody>();
            Vector3 vel = camPos.position - rb.transform.position;
            float x, y, z;
            x = (vel.x / 1.9f)*50;//vel.y * 20;
            y = (10f)*50;
            z = (vel.z / 1.9f)*50;

            vel.y = y;
            vel.x = Random.Range(x-15, x+15);
            vel.z = Random.Range(z-15, z+15);

            rb.AddForce(vel);

            //rb.velocity = vel;

            rb.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));

    }
}
