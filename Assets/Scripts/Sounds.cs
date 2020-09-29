using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sounds : MonoBehaviour
{
    // Start is called before the first frame update
    
   public  AudioClip shoot, move;
   public AudioSource audio;
    bool inter = true;
    void Start()
    {
        //shoot = Resources.Load<AudioClip>( "Tank Firing");
        //move = Resources.Load<AudioClip>("move");
        //audio=GetComponent<AudioSource>();

    } 

    // Update is called once per frame
    void Update()
    {
        
    }
    public void play_sounds(string sound)
    {
       

         if (sound == "move")
        {
            audio.PlayOneShot(move);
            
            
        }
        
       
    }
}
