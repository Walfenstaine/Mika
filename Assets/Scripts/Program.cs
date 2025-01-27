using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using static Data;
using static Interface;

public class Program : MonoBehaviour
{
    public Data data;

    float timer = 0;
    private void Start()
    {
        for (int i = 0; i < data.pers.Length; i++) 
        {
            if (data.pers[i].isPlayer) 
            {
                data.pers[i].record = data.record;
            }
        }
        Array.Sort(data.pers, (p1, p2) => p2.record.CompareTo(p1.record));
        timer = Time.time + 3;
    }



    private void FixedUpdate()
    {
        if (timer < Time.time) 
        {
            Start();
        }
    }
}
