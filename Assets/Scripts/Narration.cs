using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Narration : MonoBehaviour
{
    public Transform box;
    public Transform text;
    private Text description;
    private bool reacting;
    private float reactionTime;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (reacting)
        {
            reactionTime += Time.deltaTime;
            if (reactionTime >= 15)
            {
                RemoveText();
                reacting = false;
            }
        }
    }

    public void DisplayText(string subject)
    {
        print("DisplayText");
        box.gameObject.SetActive(true);
        description = text.GetComponent<Text>();
        switch (subject)
        {
            // Inventory Items
            case "none":
                description.text = "Walk around with my hands empty. Not good for anything other than punching the enemies that this game does not have.";
                break;
            case "gumInv":
                description.text = "A piece of gum I chewed on for a few years until my wife said I should be smoking cigarettes instead. It is REALLY sticky.";
                break;
            case "toenailInv":
                description.text = "I had to clip this sucker after I saw that my big toe was starting to grow its own eco system. I forgot how long it was...";
                break;
            case "shoestringInv":
                description.text = "I KNEW that cat made off with this! It's long enough to use as a makeshift rope.";
                break;
            case "remoteInv":
                description.text = "Ol' reliable...as long as it has a working set of batteries. Once it is working, I can turn on the TV and get out of here!";
                break;
            case "glovesInv":
                description.text = "My wife insists that I use these when doing dirty work, or else she'll get the spoon out again.";
                break;
            case "batteryInv":
                description.text = "These only have enough juice in them to last for a few more seconds, so I will need to pick'em all up and turn on the TV fast.";
                break;

            // Observations

            // Reactions
            case "batteryPickUp1":
                description.text = "These batteries have a short charge on them, so I will have to grab the other two batteries quickly! This is the most I have moved since gym class.";
                reactionTime = 0;
                reacting = true;
                break;

            case "batteryPickUp2":
                description.text = "Just one more to go! Man, I hate exercise...";
                reactionTime = 0;
                reacting = true;
                break;

            case "batteryPickUp3":
                description.text = "That's the last one! Now I can turn the TV on!";
                reactionTime = 0;
                reacting = true;
                break;

            case "timerFailure":
                description.text = "Drat! The batteries ran out of charge. Hopefully, there will be more in one of those dust piles. I never really paid attention to where these things were getting disposed to.";
                reactionTime = 0;
                reacting = true;
                break;

            case "dustPile":
                description.text = "One of the batteries to my remote is in that pile of dust! I would grab it, but if my wife sees me covered in filth again, she is getting the spoon back out. I need something to cover my hands with before grabbing it.";
                reactionTime = 0;
                reacting = true;
                break;

        }
    }

    public void RemoveText()
    {
        box.gameObject.SetActive(false);
    }
}
