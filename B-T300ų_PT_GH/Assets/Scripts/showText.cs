using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showText : MonoBehaviour
{
    // Check to see if the player has triggered the NPC
    private GameObject triggeringNPC;
    private bool triggering;

    public string textValue;
    public Text textElement;

    // Start is called before the first frame update
    void Start(){
        textElement.text = textValue;  
    }

    // Update is called once per frame
    void Update(){
        // Triggering means when the player's collider collides with the NPC's collider
        if(triggering){
            if(Input.GetKeyDown(KeyCode.Mouse0)){
                // This is just a placeholder, we can pass through the actual value for the temps from the other script by using a getter
                textElement.text = "271 Degrees";
            }
            else if(Input.GetKeyDown(KeyCode.Mouse1)){
                // Give them a donut instead and calm them down, this is just a placeholder
                textElement.text = "141 Degrees";
            }
            // Clear the message after 5 seconds if no input is detected
            else if(!Input.anyKey){
                // Not all NPCs will say take care boss, but we can make two cases where ones who had a positive reception say that, and ones who had a negative reception
                // say something else. We can track reception by using a boolean flag
                textElement.text = "Take care boss!";
            }
        }
    }

    // Check to see the player has triggered the NPC
    void OnTriggerEnter(Collider other){
        if(other.tag == "NPC"){
            triggering = true;
            triggeringNPC = other.gameObject;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.tag == "NPC"){
            triggering = false;
            triggeringNPC = null;
        }
    }
}

/*
Backup of Functioning Temp Display 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class showText : MonoBehaviour
{
    // Check to see if the player has triggered the NPC
    private GameObject triggeringNPC;
    private bool triggering;

    public string textValue;
    public Text textElement;

    // Start is called before the first frame update
    void Start(){
        textElement.text = textValue;  
    }

    // Update is called once per frame
    void Update(){
        if(triggering){
            if(Input.GetKeyDown(KeyCode.Mouse0)){
                textElement.text = "271 Degrees!";
            }
            // Clear the message after 5 seconds if no input is detected
            else if(!Input.anyKey){
                textElement.text = "Take care boss!";
            }
        }
    }

    // Check to see the player has triggered the NPC
    void OnTriggerEnter(Collider other){
        if(other.tag == "NPC"){
            triggering = true;
            triggeringNPC = other.gameObject;
        }
    }
    void OnTriggerExit(Collider other){
        if(other.tag == "NPC"){
            triggering = false;
            triggeringNPC = null;
        }
    }
}

*/
