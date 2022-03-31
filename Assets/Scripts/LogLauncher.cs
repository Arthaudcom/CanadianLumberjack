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
    private List<GameObject> liste2 = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

    }

    Vector3 Fly(Vector3 logPos)
    {
        Vector3 vel = camPos.position - logPos;

        float x, y, z;
        x = (vel.x / 1.9f) * 50;//vel.y * 20;
        y = (10f) * 50;
        z = (vel.z / 1.9f) * 50;

        vel.y = y;
        vel.x = Random.Range(x - 35, x + 35);
        vel.z = Random.Range(z - 35, z + 35);

        return vel;
    }

    // Update is called once per frame
    void Update()
    {

        float current = Time.time;

        if (current > time)
        {
            time += interpolationPeriod;

            var rnd = new System.Random();
            int Buche = rnd.Next(1, 4);  // creates a number between 1 and 3

            switch (Buche)
            {
                case 1:
                    GameObject newBuche = Instantiate(monPrefab, new Vector3(133, 0.5f, 81), Quaternion.identity);
                    liste.Add(newBuche);
                    Rigidbody rb = newBuche.GetComponent<Rigidbody>();
                    rb.AddForce(Fly(rb.transform.position));
                    rb.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));
                    break;

                case 2:
                    GameObject newBuche2 = Instantiate(monPrefab, new Vector3(140, 0.5f, 90), Quaternion.identity);
                    liste.Add(newBuche2);
                    Rigidbody rb2 = newBuche2.GetComponent<Rigidbody>();
                    rb2.AddForce(Fly(rb2.transform.position));
                    rb2.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));
                    break;

                case 3:
                    GameObject newBuche3 = Instantiate(monPrefab, new Vector3(140, 0.5f, 70), Quaternion.identity);
                    liste.Add(newBuche3);
                    Rigidbody rb3 = newBuche3.GetComponent<Rigidbody>();
                    rb3.AddForce(Fly(rb3.transform.position));
                    rb3.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));
                    break;
                    break;
            }

            /*
            GameObject newBuche = Instantiate(monPrefab, new Vector3(133, 0.5f, 81), Quaternion.identity);
            liste.Add(newBuche);
            GameObject newBuche2 = Instantiate(monPrefab, new Vector3(140, 0.5f, 90), Quaternion.identity);
            liste.Add(newBuche2);
            GameObject newBuche3 = Instantiate(monPrefab, new Vector3(140, 0.5f, 70), Quaternion.identity);
            liste.Add(newBuche3);
            Rigidbody rb = newBuche.GetComponent<Rigidbody>();
            Rigidbody rb2 = newBuche2.GetComponent<Rigidbody>();
            Rigidbody rb3 = newBuche3.GetComponent<Rigidbody>();
            //rb.AddForce(Random.Range(-23,-23), Random.Range(10,10), Random.Range(-5, -5), ForceMode.Impulse);


            rb.AddForce(Fly(rb.transform.position));
            rb2.AddForce(Fly(rb2.transform.position));
            rb3.AddForce(Fly(rb3.transform.position));

            //rb.velocity = vel;

            rb.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));
            rb2.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));
            rb3.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));*/

            if (current > interpolationPeriod * 3)
            {
                time2 += 2 * interpolationPeriod;
                GameObject o = liste[0];
                liste.Remove(o);
                Destroy(o);

            }

        }
    }
}
