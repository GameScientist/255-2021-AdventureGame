using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public Transform battery;
    public Timer timer;
    private bool hasBattery = true;
    public Narration narration;

    public void PlayerInteract()
    {
        if (hasBattery)
        {
            if (ItemSwitching.main.equipped == 4)
            {
                // remember that the player has "picked up" the object
                Inventory.main.batteries += 1;
                timer.TimeTrial();
                // destroy this game object:
                battery.gameObject.SetActive(false);
                hasBattery = false;
                switch (Inventory.main.batteries)
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
            }

            else
            {
                narration.DisplayText("dustPile");
            }
        }

        else
        {

        }
    }

    public void Respawn()
    {
        battery.gameObject.SetActive(true);
        hasBattery = true;
    }
}
