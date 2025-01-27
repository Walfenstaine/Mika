using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SoundButton : MonoBehaviour
{
    public Data data;
    public Image image;
    public Sprite on, off;
    public AudioSource sorse;

    public void Start()
    {
        sorse = SoundPlayer.regit.sorse;
        sorse.enabled = data.audio;
        if (data.audio)
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
        //YandexGame.SaveProgress();
    }
    public void Onclicker() 
    {
        data.audio = !data.audio;
        if (data.audio) 
        {
            image.sprite = on;
        }
        else
        {
            image.sprite = off;
        }
        sorse.enabled = data.audio;
    }
}
