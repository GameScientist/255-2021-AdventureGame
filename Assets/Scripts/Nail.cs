using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Can be used by the player with the shoelace to climb out of the hole in the beginning of the game.
/// </summary>
public class Nail : MonoBehaviour
{
    private bool outOfHole = false; // Once the player is out of the hole, different narration is given.
    private bool timerActivated = false; // The timer will only go up after it has been started by using the shoelace on the nail.
    private float audioTime; // Once two seconds are up, the in-game audio will stop playing.
    private float timer = 0f; // Teleportation and sound effects are triggered only after the screen is fully obscured by the transition static.

    public static ItemSwitching _main; // Used to find out what item the player is currently equipping.
    public ItemSwitching equip; // Used to change the item the player is equipping.
    public Movement movement; // Used to activate the teleportation method for the player.
    public Narration narration; // Provides messages to the player depending on how the player interacts with it.
    public StaticScreenTransition transition; // The transition plays once the player climbs out of the hole.

    private void Update() // Activates the transition, teleports the player, and plays sound effects based on the current state of the timers for the transition and audio.
    {
        if (outOfHole && audioTime < 2f)
        {
            audioTime += Time.deltaTime;
            if (audioTime >= 2f)
            {
                FindObjectOfType<AudioManager>().Stop("RopeClimb");
                FindObjectOfType<AudioManager>().Stop("Grunting");
            }
        }

        if (timerActivated)
        {
            timer++;
            if (timer >= 60)
            {
                movement.teleporting = true;
                outOfHole = true;
                Inventory.main.hasShoelace = false;
                equip.EquipItem(0);
                narration.DisplayText("climb");
                FindObjectOfType<AudioManager>().Play("RopeClimb");
                FindObjectOfType<AudioManager>().Play("Grunting");
                timerActivated = false;
            }
        }
    }

    public void PlayerInteract() // Responds to player interaction based on if the player has the correct item or is out of the hole.
    {
        if (outOfHole) // Once the player solves the first puzzle, there is no need for the player to go back into the hole.
        {
            narration.DisplayText("outOfHole");
            FindObjectOfType<AudioManager>().Play("Hmmm");
        }

        else
        {
            if (ItemSwitching.main.equipped == 3) // The player can climb out of the hole by using the shoelace on the nail.
            {
                transition.gameObject.SetActive(true);
                transition.fadingIn = true;
                timerActivated = true;
            }

            else
            {
                narration.DisplayText("nail"); // The narration gives an observation on the nail.
                FindObjectOfType<AudioManager>().Play("Hmmm");
            }
        }
    }
}
