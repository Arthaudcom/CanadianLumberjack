using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour

{
    public int score;
    public Text scoreText;
    public Score gameManager;
    // Start is called before the first frame update
    void Start()
    {
        scoreText.GetComponent<Text>().text = "Score: "+ score;
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addScore()
    {
        score += 100;
        scoreText.GetComponent<Text>().text = "Score: " + score;
    }
}