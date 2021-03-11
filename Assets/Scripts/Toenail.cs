using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toenail : MonoBehaviour
{
    /// <summary>
    /// The toenail object the player can collect and store in the inventory.
    /// </summary>
    public Narration narration; // Plays when the player picks up the object.
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasToenail = true;

        // destroy this game object:
        Destroy(gameObject);

        narration.DisplayText("toenailPickup");

        FindObjectOfType<AudioManager>().Play("Scrape");
    }
}
