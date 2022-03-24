using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Score : MonoBehaviour

{
    public int score;
    public Text scoreText;
    public Score gameManager;
    public Transform camPos;
    public ArmesScript armesScript;
    public bool t = true;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Score: "+ score;
        armesScript = GameObject.FindGameObjectWithTag("Armes").GetComponent<ArmesScript>();
       
    }

    // Update is called once per frame
    void Update()
    {
        //lignes pour que le text se trouve en face du regard du joueur
        //Vector3 targetPoint = Camera.main.transform.position;
        //scoreText.transform.LookAt(targetPoint, Vector3.up);


        if(score >= 500 && t)
        {
            armesScript.deleteArmes();
            armesScript.newArme();
            t = false;
        }
    }

    public void addScore()
    {
        score += 100;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
