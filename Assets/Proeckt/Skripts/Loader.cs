using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Data;
using static Interface;

public class Loader : MonoBehaviour
{
    public Data data;
    private void Start()
    {
        if (PlayerPrefs.HasKey("IsSaved"))
        {
            data.isSaved = PlayerPrefs.GetInt("IsSaved") == 1 ? true : false;
            if (!data.isSaved)
            {
                Interface.rid.Sum(6, true, 1);
            }
            else
            {
                Interface.rid.Sum(0, true, 1);
            }

            if (PlayerPrefs.GetInt("IsSaved") == 1)
            {
                string globalDataJSON = PlayerPrefs.GetString("Inventar");
                MyList loadedList = JsonUtility.FromJson<MyList>(globalDataJSON);
                for (int i = 0; i < loadedList.list.Length; i++)
                {
                    data.inv[i] = loadedList.list[i];
                }

                string pls = PlayerPrefs.GetString("Records");
                MyList pld = JsonUtility.FromJson<MyList>(pls);
                for (int i = 0; i < pld.list.Length; i++)
                {
                    data.pers[i].record = pld.list[i];
                }

                data.pl_name = PlayerPrefs.GetString("PLname");
                data.record = PlayerPrefs.GetInt("Record");
                data.coins = PlayerPrefs.GetInt("Coins");
                data.pol = PlayerPrefs.GetInt("Pol");
                data.language = PlayerPrefs.GetString("Langwich");

            }
            else
            {
                for (int i = 0; i < data.inv.Length; i++)
                {
                    data.inv[i] = 5;
                }
                data.record = 0;
                data.coins = 30;
                data.language = "ru";
                data.isSaved = false;
            }
        }
        else
        {
            for (int i = 0; i < data.inv.Length; i++)
            {
                data.inv[i] = 5;
            }
            data.record = 0;
            data.coins = 30;
            data.language = "ru";
            data.isSaved = false;
        }
    }

    public void Starter()
    {
        PlayerPrefs.DeleteAll();
        for (int i = 0; i < data.inv.Length; i++)
        {
            data.inv[i] = 5;
        }
        data.record = 0;
        data.coins = 30;
        data.language = PlayerPrefs.GetString("Langwich");
        data.isSaved = false;
        SceneManager.LoadScene("Scene1");
    }

    public void loader() 
    {
        SceneManager.LoadScene("Scene1");
    }

    public void Quit()
    {
        for (int i = 0; i < data.pers.Length; i++) 
        {
            int ran = UnityEngine.Random.Range(data.pers[i].min, data.pers[i].max);
            if (!data.pers[i].isPlayer) 
            {
                data.pers[i].record += ran;
            }
        }
        
        Invoke("Qut", 0.5f);
    }
    public void Qut() 
    {
        Interface.rid.SaveGame();
        Application.Quit();
    }
}
