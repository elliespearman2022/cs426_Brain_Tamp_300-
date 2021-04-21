using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreBoard : MonoBehaviour
{
    public GameObject scorePoint;
    private int score;
    // Start is called before the first frame update
    void Start()
    {
        score = 0;
        //scorePoint = GameObject.Find("Score Text");
        //.GetComponent<Text>()
        scorePoint.GetComponent<Text>().text = "Score : 0/5";
    }

    public void addPoint()
    {
        score++;
        scorePoint.GetComponent<Text>().text = "Score : " + score + "/5";
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
