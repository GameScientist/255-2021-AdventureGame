using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narration : MonoBehaviour
{
    public Transform box;
    private Text description;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DisplayText(string subject)
    {
        description = GetComponent<Text>();
        switch (subject)
        {
            // Inventory Items
            case "none":
                description.text = "Walk around with my hands empty. Not good for anything other than punching the enemies that this game does not have.";
                break;
            case "gumInv":
                description.text = "A piece of gum I chewed on for a few years until my wife said I should be smoking cigarettes instead. It is REALLY sticky, but I am greasy enough that it doesn't stick onto me.";
                break;
            case "toenailInv":
                description.text = "I had to clip this sucker after I saw that my big toe was starting to grow its own eco system. I forgot how long it was...";
                break;
            case "shoestringInv":
                description.text = "I KNEW that cat made off with this! It's long enough to use as a makeshift rope.";
                break;
            case "remoteInv":
                description.text = "Ol' reliable...as long as it has a working set of batteries.";
                break;
            case "glovesInv":
                description.text = "My wife insists that I use these when doing dirty work, or else she'll get the spoon out again.";
                break;
            case "batteryInv":
                description.text = "These only have enough juice in them to last for a few more seconds, so I will need to pick'em all up and turn on the TV fast.";
                break;
        }
        box.gameObject.SetActive(true);
    }

    public void RemoveText()
    {
        box.gameObject.SetActive(false);
    }
}
