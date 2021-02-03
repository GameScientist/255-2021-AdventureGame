using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TitleScreen : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        { // Did the user click on this game tick?
            SceneManager.LoadScene("Couch");
        }
    }
}
