using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Batteries can be collected here, but they all must be collected in quick succession, or else they will reset.
/// </summary>
public class Battery : MonoBehaviour
{
    private bool hasBattery = true; // Tracks whether a battery can be picked up from the pile.
    public Narration narration; // Allows the narration to be changed upon interaction.
    public Transform battery; // The battery object that appears as part of the dust pile.
    public Timer timer; // Tracks how much time is left until the batteries reset.

    public void PlayerInteract() //Stores a battery in the inventory and starts a timer for how long the batteries will last.
    {
        if (hasBattery)
        {
            if (ItemSwitching.main.equipped == 5) // Batteries can only be retrieved from dust piles with the rubber gloves.
            {
                Inventory.main.batteries += 1;
                timer.TimeTrial();
                // destroy this game object:
                battery.gameObject.SetActive(false);
                hasBattery = false;
                switch (Inventory.main.batteries) // The narration differs depending on how many batteries were retrieved.
                {
                    case 1:
                        narration.DisplayText("batteryPickUp1");
                        break;
                    case 2:
                        narration.DisplayText("batteryPickUp2");
                        break;
                    case 3:
                        narration.DisplayText("batteryPickUp3");
                        break;
                }
                FindObjectOfType<AudioManager>().Play("Rustling");
            }
            else
            {
                narration.DisplayText("dustPile"); // Occurs if the player tries to pick up a battery without any rubber gloves.
                FindObjectOfType<AudioManager>().Play("Hmmm");
            }
        }
    }

    public void Respawn() // The batteries will respawn if the player runs out of time.
    {
        battery.gameObject.SetActive(true);
        hasBattery = true;
    }
}
