using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationStateController : MonoBehaviour
{

    Animator animator; // Makes animator reference variable
    int isRunningHash; // Definerer isRunningHash
    int isJumpingHash;

    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>(); // Henter animationene som er i Animator
        isRunningHash = Animator.StringToHash("isRunning"); // Definerer stringen "isRunning" om til isRunningHash
        isJumpingHash = Animator.StringToHash("isJumping");
    }

    // Update is called once per frame
    void Update()
    {
        bool isRunning = animator.GetBool(isRunningHash);
        bool forwardPressed = Input.GetKey(KeyCode.RightArrow) || Input.GetKey("d") || Input.GetKey(KeyCode.LeftArrow) || Input.GetKey("a");

        bool isJumping = animator.GetBool(isJumpingHash);
        bool uppwardsPressed = Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.Space);

        bool grounded = this.GetComponent<Bean>().space_press;

        if (!isRunning && forwardPressed) // Hvis Høyre pilknapp eller D blir trykket
        {

            animator.SetBool(isRunningHash, true); // Setter isRunning til true og starter animasjonen til å løpe

        }

        if (isRunning && !forwardPressed) // Hvis høyre pilknapp eller D ikke blir trykket
        {

            animator.SetBool(isRunningHash, false); // Setter isRunning til false og stopper animasjonen for å løpe

        }

        if (!isJumping && uppwardsPressed && grounded)
        {
            animator.SetBool(isJumpingHash, true);

        }

        else
        {

            animator.SetBool(isJumpingHash, false);

        }

    }
}
