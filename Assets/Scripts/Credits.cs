using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Credits : MonoBehaviour
{
    /// <summary>
    /// This script reacts to player interactivty within the final scene of the game. It allows the player to click to show the credits, then click again to quit the game.
    /// </summary>
    private bool onCredits; // Registers whether the player currently being shown the credits screen.
    public GameObject endScreen; // The panel that describes the game's ending.
    public StaticScreenTransition transition; // Appears in between both panels to disguise the disappearance of one of the panels.
    private float timer; // Tracks how long the transition has been active for.
    private bool timerActivated; // Used to start adding onto the timer.

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
            if (onCredits) Application.Quit();
            else
            {
                endScreen.SetActive(false);
                onCredits = true;
            }
            timerActivated = false;
            timer = 0;
        }
    }
}
