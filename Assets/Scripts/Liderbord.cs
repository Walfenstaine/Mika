using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using static Data;
public class Liderbord : MonoBehaviour
{
    public Pers[] pers = new Pers[16];
    public Data data;
    public GameObject bord;

    private void Awake()
    {
        Invoke("OnStarter", 0.2f);
    }
    void OnStarter()
    {
        bord.SetActive(true);
    }
    private void Update()
    {
        //if (Input.GetKey(KeyCode.P)&& Input.GetKey(KeyCode.I)&& Input.GetKey(KeyCode.Y)) 
        //{
            //for (int i = 0; i < data.pers.Length; i++)
            //{
                //if (data.pers[i].isPlayer)
                //{
                    //data.pers[i].record = data.record;
                //}

            //}
            //data.pers = pers;
           // PlayerPrefs.DeleteAll();
            //Interface.rid.SaveGame();
       // }
       
        
    }
}
