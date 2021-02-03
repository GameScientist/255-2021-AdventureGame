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
        if (outOfHole) // Once the player solves the first puzzle, there is no need for the player to go back into the hole.
        {
            narration.DisplayText("outOfHole");
        }

        else
        {
            if (ItemSwitching.main.equipped == 3) // The player can climb out of the hole by using the shoelace on the nail.
            {
                movement.teleporting = true;
                outOfHole = true;
                Inventory.main.hasShoelace = false;
                ItemSwitching.main.equipped = 0;
                narration.DisplayText("climb");
            }

            else
            {
                narration.DisplayText("nail"); // The narration gives an observation on the nail.
            }
        }
    }
}
