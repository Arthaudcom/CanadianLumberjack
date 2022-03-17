using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ProgressBarFire : MonoBehaviour
{

    public Slider slider;

    // Start is called before the first frame update
    void Start()
    {
        slider.value = 2000;

    }

    // Update is called once per frame
    void Update()
    {
        slider.value = slider.value - 0.2f;
        if(slider.value )
    }

    public void addValue()
    {
        slider.value = slider.value + 100;


    }
}
   
