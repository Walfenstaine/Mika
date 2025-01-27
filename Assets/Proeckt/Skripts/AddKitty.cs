using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class AddKitty : MonoBehaviour
{
    public AudioClip clip;
    public Data data;
    float timer = 0;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TNT")
        {
            
            if (timer <= Time.time) 
            {
                SoundPlayer.regit.Play(clip, 1);
                timer = Time.time + 2;
            }
            
            data.record += 1;
            data.coins += 5;
            data.isSaved = true;
            Interface.rid.SaveGame();
            Destroy(other.gameObject);
        }
        else 
        {
            if (other.tag == "Player") 
            {
                Interface.rid.SaveGame();
                Interface.rid.Sum(3,true,0);
            }
        }
    }
}
