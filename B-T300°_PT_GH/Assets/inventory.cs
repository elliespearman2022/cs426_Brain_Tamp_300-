using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class inventory : MonoBehaviour
{
    public UnityEvent donut1;
    public UnityEvent donut2;
    public UnityEvent donut3;
    int inventoryMax;
    int inventoryTotal;
    int donuts;
    bool hot;
    // Start is called before the first frame update
    void Start()
    {
        inventoryMax = 3;
        inventoryTotal = 3;
        donuts = 3;
        hot = true;
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
