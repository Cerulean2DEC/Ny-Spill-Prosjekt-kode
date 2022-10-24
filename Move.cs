using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    public Rigidbody rb;
    float bean_horizontal = 1;
    float speed = 10f;
    float rotation_y = 0;
    // Update is called once per frame
    void Update()
    {
    }

    void FixedUpdate()
    {
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
