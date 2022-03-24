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
    ArmesScript armesScript = new ArmesScript();

    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Score: "+ score;

       
    }

    // Update is called once per frame
    void Update()
    {
        //lignes pour que le text se trouve en face du regard du joueur
        //Vector3 targetPoint = Camera.main.transform.position;
        //scoreText.transform.LookAt(targetPoint, Vector3.up);


        if(score >= 500)
        {
            armesScript.deleteArmes();
        }
    }

    public void addScore()
    {
        score += 100;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}
