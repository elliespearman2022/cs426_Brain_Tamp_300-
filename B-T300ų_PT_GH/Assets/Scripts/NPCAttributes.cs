using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

/*
THIS FILE IS NO LONGER USED. EACH NPC HAS THEIR OWN SCRIPT
*/

public class NPCAttributes : MonoBehaviour
{
    public UnityEvent scoreing;

    // These are in regards to the player collider and NPC collider
    private GameObject triggeringNPC;
    private bool triggering;
    private bool scored;

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
    
    // Each NPCs individual temp value
    public int npc1Temp = 0;
    public int npc2Temp = 0; 
    public int npc3Temp = 0; 
    public int npc4Temp = 0;

    // The temperature for the NPC
    public int npcTemp;

    // The value to store the random generated values
    public int x;
    
    // The number that will determine which NPC(s) have a temp of over 300, TO BE IMPLEMENTED LATER
    // For now there is a hardcoded NPC temp for 300
    public int randNPC;

    // Empty Constructor
    public NPCAttributes(){

    }

    // Default Constructor
    public NPCAttributes(int npcTemp){
        this.npcTemp = npcTemp;
    }


    // This is the function to generate the temps for the NPCs
    public void randomTemp(){
        npc1Temp = Random.Range(80,300);
        npc2Temp = Random.Range(80,300); 
        npc3Temp = Random.Range(80,300); 
        npc4Temp = Random.Range(80,300); 
 
    }

    // NOT NEEDED BUT KEPT JUST IN CASE
    // Assigns the temps to the NPCs
    // public int generateTemp(){
    //     // for(int i = 0; i < 3; i++){
    //     //     for(int j = 0; j < 3; j++){

    //     //     }
    //     // }
    //     randomTemp(x) = npc1Temp; 
    // }

    public void score()
    {
        if(scored)
        {
          scored = false;
          scoreing.Invoke();
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        NPCAttributes NPC1 = new NPCAttributes(npc1Temp);
        NPCAttributes NPC2 = new NPCAttributes(npc2Temp);
        NPCAttributes NPC3 = new NPCAttributes(npc3Temp);
        NPCAttributes NPC4 = new NPCAttributes(npc4Temp);
        
        Debug.Log("NPC 1 Temp: " + NPC1.npc1Temp);
        Debug.Log("NPC 2 Temp: " + NPC2.npc2Temp);
        Debug.Log("NPC 3 Temp: " + NPC3.npc3Temp);
        Debug.Log("NPC 4 Temp: " + NPC4.npc4Temp); 
        scored = true;
    }

    
    
    // Update is called once per frame
    void Update()
    {
           
    }
}
