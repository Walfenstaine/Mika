using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
public class CreateName : MonoBehaviour
{
    public UnityEvent onclick;
    public Sprite mane, wuman;
    public Color a, b;
    public Image img, img2;
    public Data data;
    public InputField fild;
    public bool man;

    public void Pol(bool m) 
    {
        man = m;

        if (man)
        {
            data.pol = 1;
            img.color = a;
            img2.color = b;
        }
        else 
        {
            data.pol = 0;
            img.color = b;
            img2.color = a;
        }
    }


    public void Insert()
    {
        if (fild.text.Length > 0)
        {
            data.pl_name = fild.text;
            Interface.rid.SaveGame();
            onclick.Invoke();
        }
        
    }
}
