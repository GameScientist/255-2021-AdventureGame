using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The shoelace item that can be picked up and stored in the player's inventory.
/// </summary>
public class Shoelace : MonoBehaviour
{
    public Narration narration; // The narration that is shown when the player interacts with the item.
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasShoelace = true;

        // destroy this game object:
        Destroy(gameObject);

        narration.DisplayText("shoelacePickup");

        FindObjectOfType<AudioManager>().Play("ShoelacePickup");
    }
}
