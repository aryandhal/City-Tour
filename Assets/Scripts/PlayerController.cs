using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5f; // Adjust this speed to your preference
    public float gravity = 9.8f; // Adjust this gravity value as needed
    private CharacterController controller;

    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    void Update()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Calculate movement direction
        Vector3 movement = new Vector3(horizontalInput, 0f, verticalInput) * moveSpeed * Time.deltaTime;

        // Move the player
        controller.Move(movement);

        // Apply gravity
        ApplyGravity();
    }

    void ApplyGravity()
    {
        // Check if the player is grounded before applying gravity
        if (!controller.isGrounded)
        {
            // Apply gravity to the player's vertical movement
            Vector3 gravityVector = new Vector3(0f, -gravity * Time.deltaTime, 0f);
            controller.Move(gravityVector);
        }
    }
}
