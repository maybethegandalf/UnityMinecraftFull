using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(CharacterController))]
public class PlayerMovement : MonoBehaviour
{

    public CharacterController controller;

    public float speed = 12F;
    public float sprintMod = 1.3F;
    float sprintModifier = 1F;

    public float gravity = -9.81F;
    public float jumpHeight = 4F;

    public Vector3 velocity;

    public Transform groundCheck;
    public float groundDistance = 0.4F;
    public LayerMask groundMask;

    public bool isGrounded;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        controller.slopeLimit = 45F;
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2F;
        }

        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        move.Normalize();

        //sprinting
        if (Input.GetKey(KeyCode.LeftShift))
            sprintModifier = sprintMod;
        else
            sprintModifier = 1F;

        controller.Move(move * speed * sprintModifier * Time.deltaTime);

        if(Input.GetButton("Jump") && isGrounded)
        {
            velocity.y = Mathf.Sqrt(jumpHeight * -2F * gravity);
        }
        if (!isGrounded)
            controller.slopeLimit = 91F;

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }
}
