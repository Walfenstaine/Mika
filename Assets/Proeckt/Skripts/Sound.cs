using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public float volume;
    public AudioClip clip;
    public void Play()
    {
        SoundPlayer.regit.Play(clip, volume);
    }
}
