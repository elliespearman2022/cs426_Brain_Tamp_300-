using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NPC1 : MonoBehaviour
{
    // // The UI text for the temperature, NOT WORKING
    // public GameObject textField;

    // Initialize an instance of the scoreboard
    public scoreBoard score;

    // // These are in regards to the player collider and NPC collider
    // private GameObject triggeringNPC;
    // private bool triggering;

    // // Check to see the player has triggered the NPC
    // void OnTriggerEnter(Collider other){
    //     if(other.tag == "NPC"){
    //         triggering = true;
    //         triggeringNPC = other.gameObject;
    //     }
    // }
    // void OnTriggerExit(Collider other){
    //     if(other.tag == "NPC"){
    //         triggering = false;
    //         triggeringNPC = null;
    //     }
    // }

    // Initialize the temp value
    public int npc1Temp = 0;

    // The string version of the temp value
    public string the1Temp;

    // This is the function to generate the temps for the NPCs
    public void randomTemp(){
        npc1Temp = Random.Range(80,500); 
    }

    // Start is called before the first frame update
    void Start()
    {
        randomTemp();
        the1Temp = npc1Temp.ToString(); 

        Debug.Log("NPC 1 Temp: " + npc1Temp);
        
    }

    // Update is called once per frame
    void Update()
    {
        // NOT NEEDED HERE YET
        
        // // Stepping into the NPC collision box
        // if(triggering){
        //     Debug.Log("Collider is functioning");
        //     // Displays the temp in the UI, NOT WORKING
        //     //textField.GetComponent<Text>().text = "Temp: " + theTemp;

        //     // Taking temp
        //     if(Input.GetKeyDown(KeyCode.Mouse1)){
        //         Debug.Log("Key is functioning");
        //         score.addPoint();   
        //     }
        // }
        
    }
}