using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float walkSpeed = 3f;
    public float sprintSpeed = 6f;
    public float crouchSpeed = 2f;
    public float gravity = -9.81f;
    public float jumpHeight = 1f;
    public float slopeForce = 5f;
    public float slopeRayLength = 1f;
    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    private Vector3 startPosition;
    private Quaternion startRotation;
    private Vector3 velocity;
    private bool isGrounded;
    private bool isSprinting;

    //private bool isCaught = false;

    private bool canMove = true; // Flag to track if the player is allowed to move
    //private bool isCaught = false; // Flag to track if the player has been caught

    private void Awake()
    {
        Debug.Log("Awake method called!");
    }

    private void Start()
    {
        startPosition = transform.position;
        startRotation = transform.rotation;
        Debug.Log("Start method called!");
    }

    private void Update()
    {
        //if (Input.GetKeyDown(KeyCode.Space))
        //{
        //    Debug.Log("Space pressed!");
        //}

        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if (isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        float speed = walkSpeed;

        float x = 0f;
        float z = 0f;

        if (canMove)
        {
            // Using GetKey to check for arrow keys directly
            if (Input.GetKey(KeyCode.A))
            {
                x = -1f; // Move left (negative x direction)
            }
            else if (Input.GetKey(KeyCode.D))
            {
                x = 1f; // Move right (positive x direction)
            }
            else
            {
                x = 0f; // No horizontal arrow key input
            }

            if (Input.GetKey(KeyCode.W))
            {
                z = 1f; // Move forward (positive z direction)
            }
            else if (Input.GetKey(KeyCode.S))
            {
                z = -1f; // Move backward (negative z direction)
            }
            else
            {
                z = 0f; // No vertical arrow key input
            }
        }
        else
        {
            // If the player is not allowed to move, set x and z to 0 to stop movement
            x = 0f;
            z = 0f;
        }

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);


        velocity.y += gravity * Time.deltaTime;

        // Check for slope angle
        if ((controller.collisionFlags & CollisionFlags.Below) == 0)
        {
            RaycastHit hit;
            if (Physics.Raycast(transform.position, Vector3.down, out hit, slopeRayLength))
            {
                float slopeAngle = Vector3.Angle(hit.normal, Vector3.up);
                if (slopeAngle > controller.slopeLimit)
                {
                    velocity += Physics.gravity * slopeForce * Time.deltaTime;
                }
            }
        }

        controller.Move(velocity * Time.deltaTime);
    }
}
