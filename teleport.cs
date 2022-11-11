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
            transform.position = new Vector3(17.88f, 1.22f, 0);

        }
    }
}
