using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class removal : MonoBehaviour
{
    private Color viven;
    private GameObject donut;
    public UnityEvent thrw;
    // Start is called before the first frame update
    void Start()
    {
        donut = gameObject;
        viven = donut.GetComponent<Renderer>().material.color;
        //viven.a = 1;
    }

    public void forward()
    {
        thrw.Invoke();
        //this.transform.forward = 1;

    }
    public void meshOff()
    {
        donut.GetComponent<Renderer>().material.SetColor("_Color", new Color(viven.r,viven.b,viven.g, 0.0f));
        forward();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
