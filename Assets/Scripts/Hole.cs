using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hole : MonoBehaviour
{
    public GameObject gloves;
    public GameObject gum;
    public Narration narration;
    private bool gummed;
    private int state = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayerInteract()
    {
        switch (state)
        {
            case 2:
                narration.DisplayText("emptyHole");
                break;

            case 1:
                if (ItemSwitching.main.equipped == 2)
                {
                    Inventory.main.hasRubberGloves = true;
                    ItemSwitching.main.equipped = 5;
                    Inventory.main.hasToenail = false;
                    Destroy(gloves);
                    Destroy(gum);
                    state++;
                    narration.DisplayText("glovePickup");
                }

                else
                {
                    narration.DisplayText("gummedHole");
                }

                break;

            case 0:
                if (ItemSwitching.main.equipped == 1)
                {
                    ItemSwitching.main.equipped = 0;
                    Inventory.main.hasGum = false;
                    gum.gameObject.SetActive(true);
                    state++;
                    narration.DisplayText("gummedHole");
                }

                else
                {
                    narration.DisplayText("hole");
                }

                break;
        }
    }
}
