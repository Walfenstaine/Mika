using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Droper_Inventar : MonoBehaviour
{
    public Data data;
    public Animator[] anim;
    public int[] kup;
    public int[] prod;
    public Language[] language;
    public AudioClip yes, no, torgi;
    public Text text, infa;
    public bool torg = false;
    public static Droper_Inventar rid { get; set; }
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
    private void FixedUpdate()
    {
        text.text = ": " + data.coins;

    }
    public void Information(int i) 
    {
        torg = true;
        if (data.language == "ru")
        {
            infa.text = language[i].ru;
        }
        else 
        {
            infa.text = language[i].en;
        }
    }
    public void Resed() 
    {
        torg = false;
        infa.text = "";
    }
    public void Torgash(int i) 
    {
        
        if (data.coins >= kup[i])
        {
            SoundPlayer.regit.Play(torgi,1);
           data.inv[i] += 1;
            data.coins -= kup[i];
        }
        else
        {
            SoundPlayer.regit.Play(no,2.5f);
        }
    }
    public void Have(int i) 
    {
        if (data.inv[i] > 0)
        {
            SoundPlayer.regit.Play(torgi,1);
            data.inv[i] -= 1;
            data.coins += prod[i];
        }
        else
        {
            SoundPlayer.regit.Play(no,2.5f);
        }

    }
    public void Hill()
    {
        if (torg)
        {
            if (data.inv[1] > 0)
            {
                if (Player_Muwer.rid.helse < 100)
                {
                    anim[1].SetTrigger("Drink");
                    SoundPlayer.regit.Play(yes, 3);
                    if (Player_Muwer.rid.helse < 90)
                    {
                        Player_Muwer.rid.helse += 10;
                    }
                    else
                    {
                        Player_Muwer.rid.helse = 100;
                        data.inv[1] -= 1;
                    }
                }
                Interface.rid.SaveGame();
            }

        }
    }

    public void Svoreder() 
    {
        if (torg)
        {
            Interface.rid.SaveGame();
            if (data.inv[0] > 0)
            {
                if (Sword.rid.svordHelse < 100)
                {
                    anim[0].SetTrigger("Drink");
                    SoundPlayer.regit.Play(yes,3);
                    if (Sword.rid.svordHelse < 90)
                    {
                        Sword.rid.svordHelse += 10;
                    }
                    else
                    {
                        Sword.rid.svordHelse = 100;
                    }
                    data.inv[0] -= 1;
                }
            }
        }
            
    }

    public void Torg()
    {
        if (torg) 
        {
            Interface.rid.SaveGame();
            if (data.inv[2] > 0)
            {
                anim[2].SetTrigger("Drink");
                SoundPlayer.regit.Play(yes,3);
                Player_Muwer.rid.Invise();
                data.inv[2] -= 1;
            }
        }
           
    }
}
