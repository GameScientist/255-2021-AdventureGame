using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nail : MonoBehaviour
{
    public Narration narration;
    private bool outOfHole = false;
    public Transform player;
    public Movement movement;
    public static ItemSwitching _main;

    public void PlayerInteract()
    {
        if (outOfHole)
        {
            narration.DisplayText("outOfHole");
        }

        else
        {
            if (ItemSwitching.main.equipped == 3)
            {
                movement.teleporting = true;
                outOfHole = true;
                Inventory.main.hasShoelace = false;
                ItemSwitching.main.equipped = 0;
                narration.DisplayText("climb");
            }

            else
            {
                narration.DisplayText("nail");
            }
        }
    }
}
