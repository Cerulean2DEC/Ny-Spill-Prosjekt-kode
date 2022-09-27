using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bean : MonoBehaviour
{
    public Rigidbody john_hanks; // Gir john_hanks physics
    public float beanjump = 1.5f; // Definerer styrken p� hoppet
    bool space_press; // Lagrer verdien n�r space blir trykket
    float bean_horizontal; // Definerer venstre og h�yre
    public float speed = 10f; // Bestemmer farten til karakteren
    float stop_clock; // Tar tiden og lagrer den
    public float delay = 1f; // Jump
    bool grounded; // Sjekker om karakteren r�rer bakken

    // Update is called once per frame
    void Update()
    {
        if (((Input.GetKeyDown(KeyCode.Space)) || (Input.GetKeyDown(KeyCode.UpArrow))) && (grounded == true)) // Sjekke om space eller opp knappen blir trykket og om karakteren r�rer bakken
        {
            if(space_press == false) // Hvis space/opp blir trykket
            {
                stop_clock = Time.time; // Lagrer n�v�rne tid

            }
            
            space_press = true; // Setter space_press til true
            grounded = false; // Setter grounded til false (sier at karakteren ikke r�rer bakken)

        }

        if (Time.time > stop_clock + delay) // Sjekker om n�v�rende tid er h�yere en stop_clock + delay
        {
            grounded = true;

        }

        bean_horizontal = Input.GetAxisRaw("Horizontal"); // Tilegner default horisontale knappene til karakteren

    }

    private void FixedUpdate() // 50fps
    {
        if (space_press) // Sjekker om space blir trykket
        {

            john_hanks.AddForce(Vector3.up * beanjump, ForceMode.Impulse); // AddForce gj�r at karakteren bruker kraft. Vector3.up gj�r at den bruker kraft oppover, og ForceMode.Impulse gj�r at den g�r oppover med egen vekt tilegnet
            space_press = false; // Sier at space/opp ikke blir trykket (igjen)

        }

        john_hanks.velocity = new Vector3(0, john_hanks.velocity.y, bean_horizontal*speed); // Legger til fart i z-aksen
    }



}
//19 to 50