using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LogLauncher : MonoBehaviour
{
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

            GameObject newBuche = Instantiate(monPrefab, new Vector3(0, 0, 0), Quaternion.identity);
            liste.Add(newBuche);
            Rigidbody rb = newBuche.GetComponent<Rigidbody>();
            rb.AddForce(Random.Range(-2,2), Random.Range(6, 10), Random.Range(-15, -8), ForceMode.Impulse);

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
