using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour
{
    public Text scoreText;
    public int score;
    // The temp of the NPC so we know if we'll add it to the score or not; NOT NEEDED
    //public NPCAttributes npcTemp;

    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //scorePoint = GameObject.Find("Score Text");
        //.GetComponent<Text>()
        scoreText.GetComponent<Text>().text = "Score : 0/4";
    }

    public void addPoint()
    {
        score++;
        scoreText.GetComponent<Text>().text = "Score : " + score + "/4";

        if(score == 4 || score > 4){
            scoreText.GetComponent<Text>().text = "4/4! Nice!";
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
