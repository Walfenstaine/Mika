using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using static Data;
using static Interface;

using System;
using System.Drawing;
public class Interface : MonoBehaviour
{
    public int[] pers = new int[16];

    public Data data;
    public UnityEvent[] sumer;
    public static Interface rid { get; set; }
    public class MyList
    {
        public int[] list;
    }
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
    public void Sum(int index, bool cursor, float scale)
    {
        if (Player_Muwer.rid) 
        {
            Player_Muwer.rid.muwe = Vector3.zero;
        }
        
        sumer[index].Invoke();
        CursorEvent(cursor);
        Time.timeScale = scale;
    }
    public void SaveGame() 
    {
        data.isSaved = true;
        PlayerPrefs.SetInt("Record", data.record);
        PlayerPrefs.SetInt("Coins", data.coins);
        PlayerPrefs.SetInt("Pol", data.pol);
        PlayerPrefs.SetInt("IsSaved", data.isSaved == true ? 1 : 0);
        PlayerPrefs.SetString("Langwich", data.language);
        PlayerPrefs.SetString("PLname", data.pl_name);

        var listInClass = new MyList();
        listInClass.list = data.inv;
        var outputString = JsonUtility.ToJson(listInClass);
        PlayerPrefs.SetString("Inventar", outputString);

        for (int i = 0; i < pers.Length; i++) 
        {
            pers[i] = data.pers[i].record;
        }
        
        var listInRecords = new MyList();
        listInRecords.list = pers;
        var outputRecords = JsonUtility.ToJson(listInRecords);
        PlayerPrefs.SetString("Records", outputRecords);
    }

    void CursorEvent(bool activ)
    {
        if (activ)
        {
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            Cursor.lockState = CursorLockMode.Locked;
        }
        Cursor.visible = activ;
    }
}
