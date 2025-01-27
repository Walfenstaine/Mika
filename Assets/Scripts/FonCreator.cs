using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FonCreator : MonoBehaviour
{
    public int index;
    public Data program;
    public GameObject pl;
    public int rang;
    public Text ra, re, na;
    public Image ava;


    private void FixedUpdate()
    {
        if (program.pers[index].isPlayer)
        {
           program.pers[index].name = program.pl_name;
           ava.sprite = program.fotos[program.pol];
        }
        else 
        {
            ava.sprite = program.pers[index].ava;
        }
        na.text = program.pers[index].name;
        re.text = "" + program.pers[index].record;
        pl.SetActive(program.pers[index].isPlayer);
       
        ra.text = "" + rang;
    }
}
