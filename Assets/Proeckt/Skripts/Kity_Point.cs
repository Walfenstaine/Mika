using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kity_Point : MonoBehaviour
{
    public bool generator;
    public GameObject kit;
    public Transform[] next;
    public Transform kitii;

    private void FixedUpdate()
    {
        if (generator) 
        {
            if (kitii == null)
            {
                kitii = Instantiate(kit).transform;
                kitii.position = transform.position;
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "TNT") 
        {
            other.GetComponent<Kitti>().Onpoint(next[Random.Range(0,2)]);
        }
    }
}
