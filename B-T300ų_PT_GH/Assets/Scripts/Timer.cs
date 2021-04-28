using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;


public class Timer : MonoBehaviour
{

    public GameObject textField;
    float timeToWin = 180f;
    float timeRemaining = 0f;
    int minRemaining;
    int secRemaining;
    //maybe add static variable or NPC array here.
    
    
    //Added material here
    public int countdownTime;
    public int beginGame = 0;
    
    IEnumerator CountdownToStart() {
        while(countdownTime > 0) {
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
	   
       beginGame = 1;
       yield return new WaitForSeconds(1f);
        
    }
    

    // Start is called before the first frame update
    void Start()
    {
        timeRemaining = timeToWin;
        textField.GetComponent<Text>().text = "Time Left: 03:00";
        StartCoroutine(CountdownToStart());
        
    }

    // Update is called once per frame  (
    void Update()
    {
        
        //If the countdown has reached 0 and it is time to start the timer.
        if(beginGame == 1) {
        
            //Time calculation.
            timeRemaining = timeRemaining - (1 * Time.deltaTime);
            minRemaining = (int)(timeRemaining / 60);
            secRemaining = (int)(timeRemaining % 60);
            
            
            /* Bug: Fix bounds here, or implement helper statements, to make timer work correctly in program.
             Current issue of showing as 00:10 and small delay between 00:01 and Game over! */
        
            
            //If there is still time remaining to beat the game.
            if(timeRemaining > 0) {
                
                //Msg shown at 00:00 to display "Game Over", even if there are still some milliseconds left in timeRemaining.
                if(minRemaining == 0 && secRemaining == 0) {
                    //textField.GetComponent<Text>().text = "Time left: 0" + minRemaining + ":0" + secRemaining;
                    textField.GetComponent<Text>().text = "Game over!";
                }
            
                //Different text output if the seconds remaining are greater than 10 seconds.
                else if(secRemaining >= 10) {
                    textField.GetComponent<Text>().text = "Time Left: 0" + minRemaining + ":" + secRemaining;
                }
                
                //Different text output if the seconds remaining are less than 10 seconds, but greater than 0.
                else if(secRemaining < 10 && secRemaining >= 0) {
                    textField.GetComponent<Text>().text = "Time Left: 0" + minRemaining + ":0" + secRemaining;
                }
                
                else {
                    textField.GetComponent<Text>().text = "Error 404";
                }
                
            }

            
            //If time has ran out!
            else if(timeRemaining <= 0) {
                
                textField.GetComponent<Text>().text = "Game Over!";
                
                //Add "You lose!" game screen / scene here, & ending game code.
                
            }
        
        
        }
        
    }
    

}
