using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform john_smith; // Henter kordinatene til 'Bean' (spilleren)
    
    // Update is called once per frame
    void Update()
    {
        this.transform.position = new Vector3(10, 4, john_smith.position.z); // Gj�r at kameraet st�r stille p� x = 10 og y = 4, mens den f�lger 'Bean' med z-aksen
    }
}
