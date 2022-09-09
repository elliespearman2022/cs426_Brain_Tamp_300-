using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script keeps continuous audio playback between scenes 1 & 2 (game and credits scene). */

public class DontDestroyMusic : MonoBehaviour
{
    private void Awake()
    {
        GameObject[] musicObj = GameObject.FindGameObjectsWithTag("GameMusic");
        if(musicObj.Length > 1) {
            Destroy(this.gameObject);
        }
        DontDestroyOnLoad(this.gameObject);
    }

}
