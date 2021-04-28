//WORKING but only for NPC1

// using __ imports namespace
// Namespaces are collection of classes, data types
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

// MonoBehavior is the base class from which every Unity Script Derives
public class CharacterControllerShooter : MonoBehaviour
{
    public float speed = 25.0f;
    public float rotationSpeed = 90;
    public float force = 700f;

    public GameObject cannon;
    public GameObject bullet;
    public GameObject donutsLeft;

    Rigidbody rb;
    Transform t;
    int donutCounter = 3;

    // These are in regards to the player collider and NPC collider
    private GameObject triggeringNPC;
    private bool triggering;

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

    // All things score related are here
    // Not Needed Anymore
    //public NPCAttributes npcTemp;
    public scoreBoard score;
    
    
    
    //Added material here
    public int countdownTime;
    public Text countdownDisplay;
    public int beginGame = 0;
    public Text temp;
    
    
    IEnumerator CountdownToStart() {
        
        while(countdownTime > 0) {
            
            countdownDisplay.text = countdownTime.ToString();
            yield return new WaitForSeconds(1f);
            countdownTime--;
        }
    
    
        countdownDisplay.text = "START!";
        beginGame = 1;
    
        yield return new WaitForSeconds(1f);
        countdownDisplay.gameObject.SetActive(false);

    }
    
    public void replenish()
    {
        donutCounter = 3;
        donutsLeft.GetComponent<Text>().text = "Donuts Left: 3/3";
    }
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        donutsLeft.GetComponent<Text>().text = "Donuts Left: 3/3";
        
        //Added material here
        StartCoroutine(CountdownToStart());
    }

    // Update is called once per frame
    void Update()
    {
        
        if(beginGame == 1) {
        
        
        
        // Time.deltaTime represents the time that passed since the last frame
        //the multiplication below ensures that GameObject moves constant speed every frame
        if (Input.GetKey(KeyCode.W))
            rb.velocity += this.transform.forward * speed * Time.deltaTime;
        else if (Input.GetKey(KeyCode.S))
            rb.velocity -= this.transform.forward * speed * Time.deltaTime;

        // Quaternion returns a rotation that rotates x degrees around the x axis and so on
        if (Input.GetKey(KeyCode.D))
            t.rotation *= Quaternion.Euler(0, rotationSpeed * Time.deltaTime, 0);
        else if (Input.GetKey(KeyCode.A))
            t.rotation *= Quaternion.Euler(0, - rotationSpeed * Time.deltaTime, 0);
        
        if (Input.GetKeyDown(KeyCode.Space))
            rb.AddForce(t.up * force);

        // https://docs.unity3d.com/ScriptReference/Input.html
        if ((Input.GetButtonDown("Fire1") && (donutCounter > 0) )){
            GameObject newBullet = GameObject.Instantiate(bullet, cannon.transform.position, cannon.transform.rotation) as GameObject;
            newBullet.GetComponent<Rigidbody>().velocity += Vector3.up * 2;
            newBullet.GetComponent<Rigidbody>().AddForce(newBullet.transform.forward * 1500);
	   donutCounter--;
	   donutsLeft.GetComponent<Text>().text = "Donuts Left: " + donutCounter + "/3";	
        }

        // Stepping into the NPC collision box
        if(triggering){
            Debug.Log("Collider is functioning");
            // Test phrase to see if the NPC needs their temperature taken if their collider isn't disabled
            if(triggeringNPC.GetComponent<BoxCollider>().isTrigger = true){
                Debug.Log("NPC Collider is Active, Needs Temp Taken");
            }    
            // If the NPC is good to go, we add a point and disable their collider
            // so the player can't keep clicking and getting points
            // FOR NPC 1
            if(triggeringNPC.GetComponent<NPC1>() == triggeringNPC.GetComponent<NPC1>()){    
                // Change the output of the temperature on the HUD
                if(Input.GetKeyDown(KeyCode.Mouse1)){
                    Debug.Log("Key is functioning");
                    temp.text = triggeringNPC.GetComponent<NPC1>().the1Temp;
                    temp.GetComponent<Text>().text = "Temp: "+ triggeringNPC.GetComponent<NPC1>().npc1Temp;
                    if(triggeringNPC.GetComponent<NPC1>().npc1Temp < 300){
                        score.addPoint();
                        // Disable their trigger collider
                        triggeringNPC.GetComponent<BoxCollider>().isTrigger = false;
                        Debug.Log("NPC Added to Score, Collider Disabled");     
                    }
                }
            }
            // FOR NPC 2
            else if(triggeringNPC.GetComponent<NPC2>() == triggeringNPC.GetComponent<NPC2>()){
                if(Input.GetKeyDown(KeyCode.Mouse1)){
                    Debug.Log("Key is functioning");
                    // Change the output of the temperature on the HUD
                    temp.text = triggeringNPC.GetComponent<NPC2>().the2Temp;
                    temp.GetComponent<Text>().text = "Temp: "+ triggeringNPC.GetComponent<NPC2>().npc2Temp;
                    if(triggeringNPC.GetComponent<NPC2>().npc2Temp < 300){
                        score.addPoint();
                        // Disable their trigger collider
                        triggeringNPC.GetComponent<BoxCollider>().isTrigger = false;
                        Debug.Log("NPC Added to Score, Collider Disabled");     
                    }
                }
            }
            // FOR NPC 3
            else if(triggeringNPC.GetComponent<NPC3>() == triggeringNPC.GetComponent<NPC3>()){
                if(Input.GetKeyDown(KeyCode.Mouse1)){
                    Debug.Log("Key is functioning");
                    // Change the output of the temperature on the HUD
                    temp.text = triggeringNPC.GetComponent<NPC3>().the3Temp;
                    temp.GetComponent<Text>().text = "Temp: "+ triggeringNPC.GetComponent<NPC3>().npc3Temp;
                    if(triggeringNPC.GetComponent<NPC3>().npc3Temp < 300){
                        score.addPoint();
                        // Disable their trigger collider
                        triggeringNPC.GetComponent<BoxCollider>().isTrigger = false;
                        Debug.Log("NPC Added to Score, Collider Disabled");     
                    }
                }
            }
            // FOR NPC 4
            else if(triggeringNPC.GetComponent<NPC4>() == triggeringNPC.GetComponent<NPC4>()){
                if(Input.GetKeyDown(KeyCode.Mouse1)){
                    Debug.Log("Key is functioning");
                    // Change the output of the temperature on the HUD
                    temp.text = triggeringNPC.GetComponent<NPC4>().the4Temp;
                    temp.GetComponent<Text>().text = "Temp: "+ triggeringNPC.GetComponent<NPC4>().npc4Temp;
                    if(triggeringNPC.GetComponent<NPC4>().npc4Temp < 300){
                        score.addPoint();
                        // Disable their trigger collider
                        triggeringNPC.GetComponent<BoxCollider>().isTrigger = false;
                        Debug.Log("NPC Added to Score, Collider Disabled");     
                    }
                }
            }
        }
        // Not needed yet
        // else{
        //     triggering = false;
        // }
        }
    }
}
