using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class feed : MonoBehaviour
{
    // Start is called before the first frame update
    private GameObject me;
    public Transform target;

    void Start()
    {
        me = gameObject;
    }

    public void fead()
    {
        if(transform.position.x - 5 > target.position.x && transform.position.x + 5 < target.position.x)
        {
            if(transform.position.y - 5 > target.position.y && transform.position.y + 5 < target.position.y)
            {
             // me.SetColor("_Color", new Color(0f,0f,1f));
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
