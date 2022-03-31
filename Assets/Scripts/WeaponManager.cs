using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponManager : MonoBehaviour
{
    public int score;
    public List<GameObject> weapons;
    public List<GameObject> activeWeapons;

    int i = 0;

    public int currentWeapon = 0;
    public int limit;
    public Transform camPos;
    void Start()
    {
        limit = 0;
    }

    // Update is called once per frame
    void Update()    {

        score = GameObject.FindGameObjectWithTag("GameManagerTag").GetComponent<Score>().score;

        if(score >= limit)
        {

            limit += 500;
            instanciateWeapon(weapons[Random.Range(0, weapons.Count - 1)]);
            currentWeapon++;
            i++;

            if(i > 3)
            {
                GameObject toDestroy = activeWeapons[0];
                activeWeapons.Remove(toDestroy);
                Destroy(toDestroy);
            }

        }
    }

    void instanciateWeapon(GameObject weapon)
    {

        if(weapon != null)
        {
            GameObject newWeapon = Instantiate(weapon, new Vector3(133, 0.5f, 81), Quaternion.identity);
            activeWeapons.Add(newWeapon);
            Rigidbody rb = newWeapon.GetComponent<Rigidbody>();
            //rb.AddForce(Random.Range(-23,-23), Random.Range(10,10), Random.Range(-5, -5), ForceMode.Impulse);

            Vector3 vel = camPos.position - rb.transform.position;
            float x, y, z;
            x = (vel.x / 1.9f) * 50;//vel.y * 20;
            y = (10f) * 50;
            z = (vel.z / 1.9f) * 50;

            vel.y = y;
            vel.x = Random.Range(x - 15, x + 15);
            vel.z = Random.Range(z - 15, z + 15);

            rb.AddForce(vel);

            //rb.velocity = vel;

            rb.AddTorque(Random.Range(-20, 20), 0, Random.Range(-20, 20));
        }

    }
}
