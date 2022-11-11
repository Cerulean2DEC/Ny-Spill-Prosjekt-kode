using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    float bean_horizontal = 1;
    float speed = 10f;
    float rotation_y = 0;


    void Update()
    {
    }

    void FixedUpdate()
    {
        // Setter kordinatene p� hvor fienden skal g�, 0 p� x, rb.velocity.y for � bruke positionen den alerede er p�, og bean_horizontal*speed for � bestemme farten den g�r p� z-aksen
        rb.velocity = new Vector3(0, rb.velocity.y, bean_horizontal * speed);
        Debug.Log(bean_horizontal);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Corner")
        {
            bean_horizontal *= -1;
            rotation_y += 180f;

            if(rotation_y >= 360)
            {
                rotation_y = 0;
            }
            transform.rotation = Quaternion.Euler(transform.rotation.x, rotation_y, transform.rotation.z);
        }
    }

}
