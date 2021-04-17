using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour
{
    
    public int countDownTime;
    public Text countdownDisplay;
    
    
    IEnumerator CountdownToStart() {
        
        while(countDownTime > 0) {
            
            countdownDisplay.text = countDownTime.ToString();
            yield return new WaitForSeconds(1f);
            countDownTime--;
        }
    
    
        countdownDisplay.text = "START!";
        //GameController.instance.BeginGame(); /*This should be maybe in CharacterController*/
    
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);
    }
    
    
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CountdownToStart());
    }

    /* // Update is called once per frame
    void Update()
    {
        
    } */
}
