using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController controller;
    public float walkSpeed = 10f;
    //public float sprintSpeed = 15f;
    //public float crouchSpeed = 5f;
    public float gravity = 0f;
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
    //private bool isSprinting;

    private bool canMove = true; // Flag to track if the player is allowed to move

    //public float rotationSpeed = 5f;

    public GameObject fireUI;
    public GameObject electricityUI;
    public GameObject waterUI;

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
            x = 0f;
            z = 0f;
        }

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        //if (move != Vector3.zero)
        //{
        //    Quaternion targetRotation = Quaternion.LookRotation(move, Vector3.up);
        //    transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, rotationSpeed * Time.deltaTime);
        //}


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

    //private void OnTriggerEnter(Collider collision)
    //{
    //    if (collision.gameObject.CompareTag("WaterPickup"))
    //    {
    //        Destroy(collision.gameObject);
    //        waterUI.SetActive(true);
    //    }
    //    if (collision.gameObject.CompareTag("ElectricityPickup"))
    //    {
    //        Destroy(collision.gameObject);
    //        electricityUI.SetActive(true);
    //    }
    //    if (collision.gameObject.CompareTag("FirePickup"))
    //    {
    //        Destroy(collision.gameObject);
    //        fireUI.SetActive(true);
    //    }

    //    //if (collision.gameObject.CompareTag("SideCollision"))
    //    //{
    //    //   
    //    //}

        
    //}
}
