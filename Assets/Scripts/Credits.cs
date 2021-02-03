using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    /// <summary>
    /// The game closes when the player clicks.
    /// </summary>

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { // Did the user click on this game tick?
            Application.Quit();
            print("Quit");
        }
    }
}
