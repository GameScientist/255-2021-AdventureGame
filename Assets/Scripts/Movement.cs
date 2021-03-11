using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Allows the player to move based on input. Also handles the teleportation of the character out of the hole when interacting with the nail.
/// </summary>
public class Movement : MonoBehaviour
{
    public CharacterController controller; // References the character controller component attached to the player character object.
    public float speed = 20f; // How quickly the player travels in the desired direction.
    Vector3 velocity; // The current speed at which the player is traveling.
    public float gravity = -100f; // How quickly the player goes down when midair.
    public Transform teleport; // Represents the location the player teleports to when climbing out of the hole.
    public bool teleporting; // If true, teleports the character.
    private float timer = 1; // Keeps the player at the teleport location for a small amount of time to prevent a glitch that sends the player character back down the hole.

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.right * x + transform.forward * z;
        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity * Time.deltaTime);

        if (teleporting) // If the player used the shoelace on the nail, they are transported out of the hole.
        {
            transform.position = teleport.position;
            timer -= Time.deltaTime;
            if (timer <= 0) // This is meant to prevent a glitch that caused the player to warp back to their previous position.
            {
                teleporting = false;
                timer = 1;
            }

        }
    }
}
