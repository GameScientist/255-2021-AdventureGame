using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narration : MonoBehaviour
{
    private Text description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void InventoryDescription(string subject)
    {
        description = GetComponent<Text>();
        switch (subject)
        {
            // Inventory Items
            case observe:
                description.text = "Allows me to take a closer look at whatever got trapped inside my couch, although I was quite content with not knowing!";
                break;
            case gum:
                description.text = "A piece of gum I chewed on for a few years until my wife said I should be smoking cigarettes instead. It is REALLY sticky, but I am greasy enough that it doesn't stick onto me.";
                break;
            case toenail:
                description.text = "I had to clip this sucker after I saw that my big toe was starting to grow its own eco system. I forgot how long it was...";
                break;
            case shoestring:
                description.text = "I KNEW that cat made off with this! It's long enough to use as a makeshift rope.";
                break;
            case remote:
                description.text = "Ol' reliable...as long as it has a working set of batteries.";
                break;
            case gloves:
                description.text = "My wife insists that I use these when doing dirty work, or else she'll get the spoon out again.";
                break;
            case battery:
                description.text = "These only have enough juice in them to last for a few more seconds, so I will need to pick'em all up and turn on the TV fast...which is why you probably shouldn't be reading this right now.";
                break;
        }
    }
}
