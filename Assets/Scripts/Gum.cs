using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gum : MonoBehaviour
{
    public Narration narration;
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasGum = true;

        // destroy this game object:
        Destroy(gameObject);

        narration.DisplayText("gumPickup");
    }
}
