using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/* This script will keep the ending credits portion of the game audio looping at the ending portion. */
/* NOTE: This has been disabled in favor of keeping continuous audio playback between scenes. */

public class CreditsAudio : MonoBehaviour
{

    [SerializeField]
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource.time = 185.2f;
        audioSource.Play();
        
    }

    // Update is called once per frame
    void Update()
    {
        if(audioSource.time > 260f) {
            audioSource.time = 184f;
            audioSource.Play();
        }
        
    }
}
