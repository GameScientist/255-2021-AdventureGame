using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Remote : MonoBehaviour
{
    // Start is called before the first frame update
    public void PlayerInteract()
    {
        // remember that the player has "picked up" the object
        Inventory.main.hasShoelace = true;

        // destroy this game object:
        Destroy(gameObject);
    }
}
