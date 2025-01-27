using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SP_Buton : MonoBehaviour
{
    public float volume = 1;
    public static event Action<AudioClip, float> play;
    public void Player(AudioClip clip)
    {
        play.Invoke(clip, volume);
       
    }
}
