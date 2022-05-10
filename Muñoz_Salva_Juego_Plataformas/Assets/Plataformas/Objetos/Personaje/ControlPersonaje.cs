using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPersonaje : MonoBehaviour
{
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    public float playerSpeed = 2.0f;
    public float jumpHeight = 1.0f;
    public float gravityValue = -9.81f;

    private Animator animator;


    private void Start()
    {
        controller = gameObject.GetComponent<CharacterController>();
        animator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        if(!groundedPlayer && controller.isGrounded)
        {
            animator.SetTrigger("Aterrizar");
        }

        groundedPlayer = controller.isGrounded;
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        Vector3 move = new Vector3( 0, 0, Input.GetAxis("Horizontal"));  //Input.GetAxis("Vertical")

        
        if (Input.GetButton("Fire1"))
        {
            move *= 2;
        }
        
        controller.Move(move * Time.deltaTime * playerSpeed);

        animator.SetFloat("VelocidadH", move.magnitude);

        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player..
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravityValue);
            animator.SetTrigger("Salto");
        }

        playerVelocity.y += gravityValue * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);

        animator.SetFloat("VelocidadV", playerVelocity.y);
    }
}
