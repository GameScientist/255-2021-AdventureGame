using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    // Start is called before the first frame update

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
