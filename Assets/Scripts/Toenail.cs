using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Toenail : MonoBehaviour
{
    public Narration narration;
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasToenail = true;

        // destroy this game object:
        Destroy(gameObject);

        narration.DisplayText("toenailPickup");
    }
}
