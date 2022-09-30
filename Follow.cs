using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform john_smith; // Henter kordinatene til 'Bean' (spilleren)
    
    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(10, 4, john_smith.position.z); // Gjør at kameraet står stille på x = 10 og y = 4, mens den følger 'Bean' med z-aksen
    }
}
