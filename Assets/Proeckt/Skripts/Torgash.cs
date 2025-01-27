using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torgash : MonoBehaviour
{
    public Animator anim;
    public AudioClip clip;
    public static Torgash rid { get; set; }
    void Awake()
    {
        if (rid == null)
        {
            rid = this;
        }
        else
        {
            Destroy(this);
        }
    }
    void OnDestroy()
    {
        rid = null;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Invise")
        {
            anim.SetBool("Open",true);
            for (int i = 0; i < Player_Muwer.rid.kitis.Count; i++)
            {
                Player_Muwer.rid.kitis[i].target = transform;
            }
            SoundPlayer.regit.Play(clip, 1.8f);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Invise") 
        {
            anim.SetBool("Open", false);
            SoundPlayer.regit.Play(clip, 1.8f);
        }    
    }
}
