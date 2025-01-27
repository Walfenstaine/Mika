using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class InventarIcon : MonoBehaviour
{
    public UnityEvent clic;
    public int index_Num;
    public Data data;
    public Image img;
    public Text text;
    float timer = 0;

    public void Click() 
    {
        timer = Time.time + 0.07f;
    }

    public void Pointer() 
    {
        if (timer >= Time.time) 
        {
            clic.Invoke();
        }
    }
    private void FixedUpdate()
    {
        text.text = "" + data.inv[index_Num];
    }
}
