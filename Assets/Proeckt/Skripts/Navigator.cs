using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Navigator : MonoBehaviour
{
    public GameObject ctrel;
    public static Navigator rid { get; set; }
    bool compas = true;
    float timer = 0;
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

    public void NavOn() 
    {
        if (Player_Muwer.rid.kitis.Count >= 10)
        {
            compas = !compas;
        }
            if (timer <= Time.time)
        {
            timer = Time.time + 10;
        }
        else 
        {
            timer = 0;
        }
    }
    private void FixedUpdate()
    {
        if (Player_Muwer.rid.kitis.Count < 10)
        {
            if (!compas)
            {
                compas = true;
            }
            if (timer > Time.time)
            {
                ctrel.SetActive(true);
                transform.LookAt(Torgash.rid.transform.position);
            }
            else
            {
                ctrel.SetActive(false);
            }

        }
        else
        {
            ctrel.SetActive(true);
            transform.LookAt(Torgash.rid.transform.position);
            ctrel.SetActive(compas);
        }
    }
}
