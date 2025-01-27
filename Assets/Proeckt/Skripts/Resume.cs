using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resume : MonoBehaviour
{
    public Data data;
    private void FixedUpdate()
    {
        if (!data.isSaved) 
        {
            Destroy(gameObject);
        }
    }
}
