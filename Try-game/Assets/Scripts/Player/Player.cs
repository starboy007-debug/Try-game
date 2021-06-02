using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public CharacterController controller;
    public float speed = 6f;
    public float gravity = -20f;
    public float jumpHeight = 2f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

   // public AudioSource walk;
   // public AudioSource land;

    Vector3 velocity;
    bool isGrounded;
    //  Animator anim;
    void Start()
    {
        //   anim = GetComponent<Animator>();

    }

    void Update()
    {
        Walk();

      //  Jump();
    }

    void Jump()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }


        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2f * gravity);

           // land.Play();
            // TakeDamage(20);
        }

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);
    }
    void Walk()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;

        //walk.Play();
        controller.Move(move * speed * Time.deltaTime);

    }

}
