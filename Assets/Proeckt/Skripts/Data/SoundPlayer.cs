using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPlayer : MonoBehaviour
{
    public AudioSource sorse;
    public static SoundPlayer regit { get; set; }
    private float tim;

    private void OnEnable()
    {
        SP_Buton.play += Play;
    }
    private void OnDisable()
    {
        SP_Buton.play  -= Play;
    }
    void Awake()
    {
        if (regit == null)
        {
            DontDestroyOnLoad(gameObject);
            regit = this;
        }
        else
        {
            Destroy(this);
        }
    }

    void OnDestroy()

    {
        regit = null;
    }

    public void Play(AudioClip clip, float v)

    {
        if (sorse.enabled) 
        {
            sorse.PlayOneShot(clip, v);
            if (Time.time > tim)
            {

                tim = Time.time + 0.01f;
            }
        }
        
    }

}
