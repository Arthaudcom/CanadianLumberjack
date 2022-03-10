using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLauncher : MonoBehaviour
{
    public Transform camPos;

    public GameObject monPrefab;
    private float time = 0.0f;

    public float interpolationPeriod;
    private float time2 = 2.0f;
    private List<GameObject> liste = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float current =Time.time;

        if (current > time)
        {
            time += interpolationPeriod;

            GameObject newBuche = Instantiate(monPrefab, new Vector3(133, 0.5f, 81), Quaternion.identity);
            liste.Add(newBuche);
            Rigidbody rb = newBuche.GetComponent<Rigidbody>();
            //rb.AddForce(Random.Range(-23,-23), Random.Range(10,10), Random.Range(-5, -5), ForceMode.Impulse);

            Vector3 vel = camPos.position - rb.transform.position;
            vel.y = vel.y * 9;
            vel.x = vel.x / 1.8f;
            vel.z = vel.z / 1.8f;

            rb.velocity = vel;

            rb.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));

            if(current > interpolationPeriod * 3)
            {
                time2 += 2 * interpolationPeriod;
                GameObject o = liste[0];
                liste.Remove(o);
                Destroy(o);
                Debug.Log(liste.Count);
            }

        }
    }
}
