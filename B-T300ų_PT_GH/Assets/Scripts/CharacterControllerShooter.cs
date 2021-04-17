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
    
    
    
    //Added material here
    public int countdownTime;
    public Text countdownDisplay;
    public int beginGame = 0;
    
    
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
    

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        t = GetComponent<Transform>();
        donutsLeft.GetComponent<Text>().text = "Donuts left: 3/3";
        
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
	   donutsLeft.GetComponent<Text>().text = "Donuts left: " + donutCounter + "/3";	
        }

        }
    }
}
