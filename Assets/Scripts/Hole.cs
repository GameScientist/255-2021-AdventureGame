using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject gloves;
    public GameObject gum;
    public Narration narration;
    private int state = 0;

    public void PlayerInteract() // This object has many different interactions depending on what items the player is using.
    {
        switch (state)
        {
            case 2: // The gloves have been retrieved from the hole, so there is no need for the player to interact with it anymore.
                narration.DisplayText("emptyHole");
                break;

            case 1:
                if (ItemSwitching.main.equipped == 2) // The toenail is lost so that the gloves can be collected.
                {
                    Inventory.main.hasRubberGloves = true;
                    ItemSwitching.main.equipped = 0;
                    Inventory.main.hasToenail = false;
                    // The gloves and gum are destroyed and narration is made to reflect the hole's current status.
                    Destroy(gloves);
                    Destroy(gum);
                    state++;
                    narration.DisplayText("glovePickup");
                }

                else // The player cannot collect the gloves without the toenail.
                {
                    narration.DisplayText("gummedHole");
                }

                break;

            case 0:
                if (ItemSwitching.main.equipped == 1) // The gum is thrown down the hole to make the gloves retrieveable.
                {
                    ItemSwitching.main.equipped = 0;
                    Inventory.main.hasGum = false;
                    // Gum appears over the gloves and narration is made to reflecct its current state.
                    gum.gameObject.SetActive(true);
                    state++;
                    narration.DisplayText("gummedHole");
                }

                // The narrator shows that the hole is interactable.
                else
                {
                    narration.DisplayText("hole");
                }
                break;
        }
    }
}
