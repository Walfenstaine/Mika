using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReclamManager : MonoBehaviour
{
    public GameObject recl, inv;

    public void Onrecl(bool a) 
    {
        recl.SetActive(a);
        inv.SetActive(!a);
    }
}
