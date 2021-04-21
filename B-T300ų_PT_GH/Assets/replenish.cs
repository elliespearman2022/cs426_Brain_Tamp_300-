using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class replenish : MonoBehaviour
{
    public UnityEvent replenishDonut;
    private GameObject player;
    private Vector3 playerPos;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("Ch36");
    }

    // Update is called once per frame
    void Update()
    {
        //this[num]: Access the x, y, z components using [0], [1], [2] respectively.
        playerPos = player.transform.position;
        if( -180 >= playerPos[2] && -200 <= playerPos[2])//z
        {
            if( 65 >= playerPos[0] && 35 <= playerPos[0])//x
            {
                replenishDonut.Invoke();
            }
        }
    }
}
