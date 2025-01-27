
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LangvichSelectijn : MonoBehaviour
{
    public Color a, b;
    public Image img, img2;
    public Data data;
    public GameObject pause;
    public bool man;
    public void Pol(bool m)
    {
        man = m;

        if (man)
        {
            img.color = a;
            img2.color = b;
        }
        else
        {
            img.color = b;
            img2.color = a;
        }
    }


    public void Insert()
    {
        if (man)
        {
            data.language = "ru";
        }
        else
        {
            data.language = "en";
        }
        Interface.rid.Sum(0,true,1);
    }
}
