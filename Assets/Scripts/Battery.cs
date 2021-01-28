using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Battery : MonoBehaviour
{
     public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.batteries += 1;

        // destroy this game object:
        Destroy(gameObject);
    }
}
