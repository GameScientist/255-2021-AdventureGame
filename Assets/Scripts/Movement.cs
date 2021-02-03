using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Movement controls.
/// </summary>
public class Movement : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 20f;
    Vector3 velocity;
    public float gravity = -10f;
    public Transform teleport;
    public bool teleporting;
    private float timer = 1;

    // Start is called before the first frame update
    void Start()
    {

    }

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
            if (timer <= 0) // This is mean to prevent a glitch that caused the player to warp back to their previous position.
            {
                teleporting = false;
                timer = 1;
            }

        }
    }
}
