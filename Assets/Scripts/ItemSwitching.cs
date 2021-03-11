using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Used to switch the player's currently equipped item while also changing its icon to communicate to the player the currently equipped item.
/// </summary>
public class ItemSwitching : MonoBehaviour
{
    public static ItemSwitching _main; // Used to prevent objects from being destroyed between scenes.
    public Transform image; // The object that holds the image used to represent specific items.

    // images
    RawImage rawImage; // The compoent of the image used to display different files.
    public Texture none;
    public Texture gum;
    public Texture toenail;
    public Texture shoelace;
    public Texture remote;
    public Texture gloves;
    public Texture battery;

    public static ItemSwitching main
    {
        get { return _main; }
    }

    public Text item; // The name of the item shown under the item icon.
    public int equipped; // The ID used to represent the item the player currently has equipped.

    private void Start() // When starting, it is decided what objects will be destroyed and what will be kept.
    {
        if (_main == null)
        {
            _main = this;
            // don't destroy this object when loading new scenes
        }
        else
        {
            Destroy(gameObject); // destroy this extra inventory system...
        }
        EquipItem(0); // The game starts with nothing equipped.
    }

    public void EquipItem(int itemId) // A different item is equipped based on the string attached to the event triggers of each button.
    {
        equipped = itemId;
        switch (itemId)
        {
            case 0:
                item.text = "None";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = none;
                break;
            case 1:
                item.text = "Gum";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = gum;
                break;
            case 2:
                item.text = "Toenail";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = toenail;
                break;
            case 3:
                item.text = "Shoelace";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = shoelace;
                break;
            case 4:
                item.text = "Remote";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = remote;
                break;
            case 5:
                item.text = "Gloves";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = gloves;
                break;
            case 6:
                item.text = "Battery";
                rawImage = image.GetComponent<RawImage>();
                rawImage.texture = battery;
                break;
        }
    }
    
}
