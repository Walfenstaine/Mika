using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public Data data;
    public int index_Icon;
    public AudioClip clip;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player" || other.tag == "Invise")
        {
            if (index_Icon <= 2)
            {
                Debug.Log("Take");
                data.inv[index_Icon] += 1;
                Interface.rid.SaveGame();
                Destroy(gameObject);
            }
            else 
            {
                Debug.Log("Take");
                data.coins += Random.Range(1,3);
                Interface.rid.SaveGame();
                Destroy(gameObject);
            }
            SoundPlayer.regit.Play(clip, 1.8f);
        }
    }
}
