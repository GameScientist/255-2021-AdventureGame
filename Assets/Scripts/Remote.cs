using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// The remote item that can be picked up and stored in the player's inventory.
/// </summary>
public class Remote : MonoBehaviour
{
    public Narration narration;
    // Start is called before the first frame update
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasRemote = true;

        // destroy this game object:
        Destroy(gameObject);

        narration.DisplayText("remotePickup");

        FindObjectOfType<AudioManager>().Play("Choir");
    }
}
