using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public GameObject textField;
    float timeToWin = 90f;
    float timeRemaining = 0f;
    //maybe add static variable or NPC array here.

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeToWin;
        textField.GetComponent<Text>().text = "Time left: 00:90";
        
    }

    // Update is called once per frame  (
    void Update()
    {
        
        //Time calculation.
        timeRemaining = timeRemaining - (1 * Time.deltaTime);
        
        
        /* Bug: Fix bounds here, or implement helper statements, to make timer work correctly in program.
         Current issue of showing as 00:010 and small delay between 00:01 and Game over! */
        
        //Different text output if the time remaining is greater than 10 seconsds.
        if (timeRemaining >= 10) {
            textField.GetComponent<Text>().text = "Time left: 00:" + timeRemaining.ToString("f0");
        }
        
        //Different text output if the time remaining is less than 10 seconds, but greater than 0.
        if (timeRemaining < 10 && timeRemaining > 0) {
            textField.GetComponent<Text>().text = "Time left: 00:0" + timeRemaining.ToString("f0");
        }
        
        //If time has ran out!
        if(timeRemaining < 0) {
            
            textField.GetComponent<Text>().text = "Game over!";
            
            //Add "You lose!" game screen / scene here, & ending game code.
            
        }
        
        

        
    }
    

}
