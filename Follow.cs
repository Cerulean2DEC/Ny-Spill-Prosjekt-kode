using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    public Transform john_smith; // Henter kordinatene til 'Bean' (spilleren)

    float something;
    void Update()
    {
        something = john_smith.transform.position.y;
        if (something < 3)
        {
            something = 3;
        }
        this.transform.position = new Vector3(john_smith.position.x + 10, something, john_smith.position.z); // Gj�r at kameraet st�r stille p� x = 10 og y = 4, mens den f�lger 'Bean' med z-aksen
    }
}
