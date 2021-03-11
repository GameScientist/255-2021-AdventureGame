using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public Inventory inventory; // Used to decide whether to set the cursor lock mode to locked if it is not open.
    public Transform pauseScreen; // Is toggled between being activated and deactivated.
    public StaticScreenTransition transition; // Plays in between opening or closing the pause menu.
    private int timer = 0; // Changes the pause menu state after sixty frames have been added onto it.
    private bool timerActivated = false; // Determines whether frames are added to the timer.
    private bool paused = false; // Tracks the pause state to always ensure that it is switching to its opposite when interacted with.

    // Update is called once per frame
    void Update()
    {
        if (timerActivated)
        {
            timer++;
            if (timer >= 60)
            {
                if (paused)
                {
                    pauseScreen.gameObject.SetActive(false);
                    Time.timeScale = 1f;
                    paused = false;
                    if (!inventory.inventoryOpened)
                    {
                        Cursor.lockState = CursorLockMode.Locked;
                    }
                }
                else
                {
                    Time.timeScale = 0f;
                    pauseScreen.gameObject.SetActive(true);
                    Cursor.lockState = CursorLockMode.Confined;
                    paused = true;
                }
                timerActivated = false;
                timer = 0;
            }
        }

        if (Input.GetKeyDown(KeyCode.Tab) && !transition.fadingIn)
        {
            if (paused) Continue();
            else
            {
                transition.gameObject.SetActive(true);
                transition.fadingIn = true;
                timerActivated = true;
            }
        }

    }

    public void Continue()
    {
        transition.gameObject.SetActive(true);
        transition.fadingIn = true;
        timerActivated = true;
    }

    public void Quit()
    {
        Application.Quit();
    }
}
