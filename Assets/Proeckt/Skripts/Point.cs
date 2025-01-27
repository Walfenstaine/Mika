using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Point : MonoBehaviour
{
    public bool isLooter = false;
    public GameObject klet;
    public GameObject[] loot;
    public Transform next;
    public GameObject kitty;
    public ParticleSystem ps;
    public void Remaine() 
    {
        if (kitty != null)
        {
            Instantiate(kitty, transform.position, Quaternion.identity);
        }
        else{
            if (isLooter)
            {
                int i = Random.Range(0, 3);
                int n = Random.Range(0, loot.Length-1);
                if (i == 2)
                {
                    Instantiate(loot[n], transform.position, Quaternion.identity);
                }
            }
            if (GetComponent<BoxCollider>()) 
            {
                GetComponent<BoxCollider>().enabled = false;
            }
           
        }
        klet.SetActive(false);
        ps.Play();
    }
    public void Reload() 
    {
        klet.SetActive(true);
        gameObject.tag = "Kitty";
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            if (other.GetComponent<Enemy>().point == transform) 
            {
                other.GetComponent<Enemy>().OnPoint(next);
            }
           
        }
    }
}
