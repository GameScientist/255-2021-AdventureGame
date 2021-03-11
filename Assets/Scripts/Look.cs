using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Controls the direction the player is point the camera in.
/// </summary>
public class Look : MonoBehaviour
{
    public float mouseSensitivity; // How quickly the player can rotate the camera.

    public Transform playerBody; // The character controller the camera is attached to.

    float xRotation = 0f; // The degree to which the player can look up or down. The player cannot "flip" its camera.

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // When the player starts, their mouse is locked to the center of the screen.
    }

    // Update is called once per frame
    void Update() // Input is gathered and the rotation of the camera is set depending on input.
    {
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * mouseSensitivity * Time.deltaTime / 2;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
