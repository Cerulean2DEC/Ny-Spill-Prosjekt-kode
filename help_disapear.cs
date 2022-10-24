using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class help_disapear : MonoBehaviour
{
    
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        
        Destroy(transform.parent.gameObject);
    }
}
