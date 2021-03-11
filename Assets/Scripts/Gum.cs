using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The "gum" item that can be collected upon player interaction.
/// </summary>
public class Gum : MonoBehaviour
{
    public Narration narration;
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasGum = true;

        // destroy this game object:
        Destroy(gameObject);

        // The narration describes what was just picked up.
        narration.DisplayText("gumPickup");

        FindObjectOfType<AudioManager>().Play("Peel");
    }
}
