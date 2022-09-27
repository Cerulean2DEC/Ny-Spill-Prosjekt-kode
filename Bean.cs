using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean : MonoBehaviour
{
    public Rigidbody john_hanks; // Gir john_hanks physics
    public float beanjump = 1.5f; // Definerer styrken på hoppet
    bool space_press; // Lagrer verdien når space blir trykket
    float bean_horizontal; // Definerer venstre og høyre
    public float speed = 10f; // Bestemmer farten til karakteren
    float stop_clock; // Tar tiden og lagrer den
    public float delay = 1f; // Jump
    bool grounded; // Sjekker om karakteren rører bakken

    // Update is called once per frame
    void Update()
    {
        if (((Input.GetKeyDown(KeyCode.Space)) || (Input.GetKeyDown(KeyCode.UpArrow))) && (grounded == true)) // Sjekke om space eller opp knappen blir trykket og om karakteren rører bakken
        {
            if(space_press == false) // Hvis space/opp blir trykket
            {
                stop_clock = Time.time; // Lagrer nåværne tid

            }
            
            space_press = true; // Setter space_press til true
            grounded = false; // Setter grounded til false (sier at karakteren ikke rører bakken)

        }

        if (Time.time > stop_clock + delay) // Sjekker om nåværende tid er høyere en stop_clock + delay
        {
            grounded = true;

        }

        bean_horizontal = Input.GetAxisRaw("Horizontal"); // Tilegner default horisontale knappene til karakteren

    }

    private void FixedUpdate() // 50fps
    {
        if (space_press) // Sjekker om space blir trykket
        {

            john_hanks.AddForce(Vector3.up * beanjump, ForceMode.Impulse); // AddForce gjør at karakteren bruker kraft. Vector3.up gjør at den bruker kraft oppover, og ForceMode.Impulse gjør at den går oppover med egen vekt tilegnet
            space_press = false; // Sier at space/opp ikke blir trykket (igjen)

        }

        john_hanks.velocity = new Vector3(0, john_hanks.velocity.y, bean_horizontal*speed); // Legger til fart i z-aksen
    }



}
//19 to 50