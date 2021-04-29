using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class employieHit : MonoBehaviour
{
    public UnityEvent score1;
    public UnityEvent score2;
    public UnityEvent score3;
    public UnityEvent score4;
    private GameObject player;
    private Vector3 playerPos;
    private bool stoped;
    // Start is called before the first frame update
    void Start()
    {
        stoped = true;
        player = GameObject.Find("Ch36");
    }

    // Update is called once per frame
    void Update()
    {
      if(stoped)
      {
        playerPos = this.transform.position;
        if( -170 >= playerPos[2] && -180 <= playerPos[2])//z
        {
            
            if( -70 >= playerPos[0] && -80 <= playerPos[0])//x
            {
                score1.Invoke();
                stoped = false;
            }
        }
        else if( -94 >= playerPos[2] && -104 <= playerPos[2])//z
        {
            
            if( -52 >= playerPos[0] && -62 <= playerPos[0])//x
            {
                score2.Invoke();
                stoped = false;
            }
        }
        else if( 168 >= playerPos[2] && 158 <= playerPos[2])//z
        {
            
            if( 53 >= playerPos[0] && 43 <= playerPos[0])//x
            {
                score3.Invoke();
                stoped = false;
            }
        }
        else if( 84 >= playerPos[2] && 74 <= playerPos[2])//z
        {
            
            if( -54 >= playerPos[0] && -64 <= playerPos[0])//x
            {
                score4.Invoke();
                stoped = false;
            }
        }
      }
    }
}
