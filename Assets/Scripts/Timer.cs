using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// The timer the player has to race against to collect all of the batteries within a short span of time.
/// </summary>
public class Timer : MonoBehaviour
{
    private float time = 0; // The current amount of time the player has left until all of the batteries respawn.
    public Text text; // The UI display showing how much time the player has left.
    private bool timerStarted = false; // Counts the timer down when true.
    public Transform panel; // The panel holding the text.
    private int intTime; // The time converted to integers so that it can be shown in seconds within the text box.

    // The dust piles that will respawn their batteries when the timer runs out.
    public Battery battery1;
    public Battery battery2;
    public Battery battery3;

    public Inventory inventory; // Used to take away all of the batteries the player has when the timer runs out.
    public Narration narration; // Used to display narration when the player runs out of time.

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            time -= Time.deltaTime;
            intTime = (int)time;
            text.text = "Charge: "  + intTime;
            if (time <= 0)
            {
                timerStarted = false;
                panel.gameObject.SetActive(false);
                battery1.Respawn();
                battery2.Respawn();
                battery3.Respawn();
                inventory.batteries = 0;
                narration.DisplayText("timerFailure");
            }
        }
    }

    public void TimeTrial()
    {
        time = 20;
        panel.gameObject.SetActive(true);
        timerStarted = true;
    }
}
