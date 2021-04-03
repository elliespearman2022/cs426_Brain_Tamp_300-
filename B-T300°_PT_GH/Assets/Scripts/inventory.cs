using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class inventory : MonoBehaviour
{
    public UnityEvent donut1;
    public UnityEvent donut2;
    public UnityEvent donut3;
    public UnityEvent load2;
    public UnityEvent load3;
    int inventoryMax;
    int inventoryTotal;
    int donuts;
    bool hot;
    bool stafe;
    // Start is called before the first frame update
    void Start()
    {
        inventoryMax = 3;
        inventoryTotal = 3;
        donuts = 3;
        hot = true;
        stafe = true;
            load2.Invoke();
            load3.Invoke();
            load3.Invoke();
    }

    void removeDonut()
    {
        if(donuts == 3)
        {
            donut1.Invoke();
        }
        else if(donuts == 2)
        {
            donut2.Invoke();
        }
        else if(donuts == 1)
        {
            donut3.Invoke();
        }//*/
        if(donuts > 0)
        {
            donuts = donuts - 1;
            inventoryTotal = inventoryTotal - 1;
            //donut1.Invoke();
        }
    }

    // Update is called once per frame
    void Update()
    {
        if(stafe)
        {
            stafe = false;
        }
        if (Input.GetKey(KeyCode.Q) && hot)
        {
            removeDonut();
            hot = false;
        }
        else if(!Input.GetKey(KeyCode.Q))
        {
            hot = true;
        }
    }
}
