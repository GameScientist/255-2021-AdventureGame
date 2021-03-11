using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

/// <summary>
/// Allows the player to click to load the intro screen, then load the couch scene. A transition is shown in between each interaction.
/// </summary>
public class TitleScreen : MonoBehaviour
{
    private bool viewingIntro = false; // Determines if clicking will load the next scene or just taking them to the intro screen.
    public GameObject titleScreen; // Becomes deactivated when the player first clicks.
    public StaticScreenTransition transition; // Plays when the user clicks.
    private float timer; // Used to determine when to change the screen or scene.
    private bool timerActivated; // Starts adding to the timer when true.

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && !transition.fadingIn)
        { // Did the user click on this game tick?
            transition.gameObject.SetActive(true);
            transition.fadingIn = true;
            timerActivated = true;
        }

        if (timerActivated) timer++;

        if (timer >= 60)
        {
            if (viewingIntro) SceneManager.LoadScene("Couch");
            else
            {
                titleScreen.SetActive(false);
                viewingIntro = true;
            }
            timerActivated = false;
            timer = 0;
        }
    }
}
