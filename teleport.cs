using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{

    void Update()
    {
        

    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Finish")
        {
            transform.position = new Vector3(-13.53f, 1f, -24.8f);

        }
    }
}
