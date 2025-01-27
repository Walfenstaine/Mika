using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "Data", menuName = "ScriptableObjects/Data", order = 1)]
public class Data: ScriptableObject
{
    public Sprite[] fotos;
    public int pol;
    public int record;
    public int coins;
    public bool audio;
    public bool isSaved = false;
    public int[] inv;

    [System.Serializable]
    public class Pers 
    {
       public int record;
       public string name;
       public bool isPlayer;
       public Sprite ava;
       public int min, max;
    }
    public Pers[] pers;
    public string language = "ru";
    public string pl_name = "Player";
}
