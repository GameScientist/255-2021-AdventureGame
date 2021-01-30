using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
    public Transform battery;
    public Timer timer;
    private bool hasBattery;

    public void PlayerInteract()
    {
        if (hasBattery)
        {
            // remember that the player has "picked up" the object
            Inventory.main.batteries += 1;
            timer.TimeTrial();
            // destroy this game object:
            battery.gameObject.SetActive(false);
            hasBattery = false;
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
