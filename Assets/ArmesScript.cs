using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArmesScript : MonoBehaviour
{
    public List<GameObject> currentArme;
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
            //Destroy(arme);
        }
    }
}
