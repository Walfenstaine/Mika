using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TreggerSensor : MonoBehaviour
{
    public UnityEvent click;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (Player_Muwer.rid.kitis.Count < 10)
            {
                click.Invoke();
                Destroy(this);
            }
        }
    }
}
