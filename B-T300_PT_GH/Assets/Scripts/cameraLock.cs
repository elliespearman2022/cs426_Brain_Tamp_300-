using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class cameraLock : MonoBehaviour
{
    public UnityEvent feeding;
    public Transform target;
    private Vector3 offset;
    bool thrown;
    int d;
    void Start()
    {
        offset.y = 1.5f;
        var x = target.position.x;
        var y = target.position.y;
        var z = target.position.z;
        thrown = false;
        d = 0;
    }
    // Start is called before the first frame update
    // Update is called once per frame
    public void Raise()
    {
        offset.y = offset.y + 1f;
    }

    public void throwing()
    {
        thrown = true;
    }

    void Update()
    {
        //if(!thrown)
            transform.position = target.position + offset;
        if(thrown)//else
        {
            feeding.Invoke();
            d++;
        }

        if(d >= 50)
        {
            thrown = false;
        }
        //transform.position = target.position;
        //x, y, z
    }
}
