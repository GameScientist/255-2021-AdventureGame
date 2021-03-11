using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
/// <summary>
/// For each player interaction, narration is given inside of a text box.
/// </summary>
public class Narration : MonoBehaviour
{
    public Transform box; // The panel that appears behind the narration text.
    public Transform text; // The text box.
    private Text description; // The text that appears inside the text box.
    private bool reacting; // Keeps the narration box appearing if it is true.
    private float reactionTime; // Tracks how long reacting has been true.

    // Start is called before the first frame update
    void Start()
    {
        DisplayText("intro"); // The game starts with the narrator screaming like a little baby.
    }

    // Update is called once per frame
    void Update() // Keeps reactions appear for a period of time after they have been called.
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

    public void DisplayText(string subject) // Enables the narration box so that text can be shown based on the subject given by other scripts.
    {
        box.gameObject.SetActive(true);
        description = text.GetComponent<Text>();
        switch (subject)
        {
            // Narration for inventory items appear as long as the player hovers their mouse over them.
            case "none":
                description.text = "Walk around with my hands empty. Not good for anything other than punching the enemies that this game does not have.";
                reacting = false;
                break;
            case "gumInv":
                description.text = "A piece of gum I chewed on for a few years until my wife said I should be smoking cigarettes instead. It is REALLY sticky.";
                reacting = false;
                break;
            case "toenailInv":
                description.text = "I had to clip this sucker after I saw that my big toe was starting to grow its own eco system. I forgot how long it was...";
                reacting = false;
                break;
            case "shoestringInv":
                description.text = " It's long enough to use as a makeshift rope.";
                reacting = false;
                break;
            case "remoteInv":
                description.text = "Ol' reliable...as long as it has a working set of batteries. Once it is working, I can turn on the TV and get out of here!";
                reacting = false;
                break;
            case "glovesInv":
                description.text = "My wife insists that I use these when doing dirty work, or else she'll get the spoon out again.";
                reacting = false;
                break;
            case "batteryInv":
                description.text = "These only have enough juice in them to last for a few more seconds, so I will need to pick'em all up and turn on the TV fast.";
                reacting = false;
                break;

            // Reactions will appear and then disappear after some time.
            case "remoteUse:":
                description.text = "I'm going to need three batteries before I can use this thing.";
                reactionTime = 0;
                reacting = true;
                break;

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
                description.text = "That's the last one! Now I can turn the TV on with the remote!";
                reactionTime = 0;
                reacting = true;
                break;

            case "timerFailure":
                description.text = "Drat! The batteries ran out of charge. Hopefully, there will be more in one of those dust piles. I never really paid attention to where these things were getting disposed to.";
                reactionTime = 0;
                reacting = true;
                break;

            case "dustPile":
                description.text = "One of the batteries to my remote is in that pile of dust! I would grab it, but if my wife sees me covered in filth again, she is getting the spoon back out.";
                reactionTime = 0;
                reacting = true;
                break;

            case "emptyHole":
                description.text = "Looking down here is making me afraid of heights.";
                reactionTime = 0;
                reacting = true;
                break;

            case "glovePickup":
                description.text = "I managed to fish out these gloves with my giant toenail. They are still pretty sticky, but as long as it is on the outside, my wife will allow me to see the end of this day.";
                reactionTime = 0;
                reacting = true;
                break;

            case "gummedHole":
                description.text = "I threw the gum down there. Now the gloves are sticky enough to attach to anything and give that thing caveties.";
                reactionTime = 0;
                reacting = true;
                break;

            case "hole":
                reactionTime = 0;
                reacting = true;
                description.text = "There are a pair of gloves down there, but I already spent too many calories climbing out of one hole, I am NOT climbing out of another!";
                break;

            case "gumPickup":
                reactionTime = 0;
                reacting = true;
                description.text = "I got the gum. Maybe I still can chew on a small piece...I think I just swallowed a bug. That is probably enough chewing for now.";
                break;

            case "toenailPickup":
                reactionTime = 0;
                reacting = true;
                description.text = "Woah! It's that toenail I clipped last month! I think that was my biggest one ever! I'm keeping this as a souvenier!";
                break;

            case "remotePickup":
                reactionTime = 0;
                reacting = true;
                description.text = "Alright! It's my remote...aaand it's out of batteries. Wonderful.";
                break;

            case "outOfHole":
                reactionTime = 0;
                reacting = true;
                description.text = "I'm not going back down there and climbing back up here again! Besides, I don't see anything useful in there, anyways.";
                break;

            case "climb":
                reactionTime = 0;
                reacting = true;
                description.text = "*Pant,* *pant,* *pant,* if somebody shot me in the butt just now, I think that would have given me less pain than that climb, but at least I am out.";
                break;

            case "nail":
                reactionTime = 0;
                reacting = true;
                description.text = "That nail looks pretty firmly stuck in the ground up there. No wonder the couch has felt so rough to sit on lately.";
                break;

            case "shoelacePickup":
                reactionTime = 0;
                reacting = true;
                description.text = "I picked up the shoelace. I KNEW that cat made off with it!";
                break;

            case "tutorial":
                reactionTime = 0;
                reacting = true;
                description.text = "Ow! I landed on my butt! It's pretty sore, but no amount of pain can prevent me from reaching my remote. But first I will need to find a way out of this hole...";
                break;

            case "intro":
                reactionTime = 0;
                reacting = true;
                description.text = "WAAAHHH!!!";
                break;

            case "null":
                reactionTime = 0;
                reacting = true;
                description.text = "Nothing to see here.";
                break;
        }
    }

    public void RemoveText() // Removes the narration box.
    {
        box.gameObject.SetActive(false);
    }
}
