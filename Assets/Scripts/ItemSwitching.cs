using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSwitching : MonoBehaviour
{
    public static ItemSwitching _main;
    public Transform image;

    // images
    RawImage rawImage;
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

    public Text item;
    public int equipped;

    private void Start()
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
        EquipItem(0);
    }

    public void EquipItem(int itemId)
    {
        equipped = itemId;
        switch (itemId)
        {
            case 0:
                item.text = "None";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = gum;
                break;
            case 1:
                item.text = "Gum";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = gum;
                break;
            case 2:
                item.text = "Toenail";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = toenail;
                break;
            case 3:
                item.text = "Shoelace";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = shoelace;
                break;
            case 4:
                item.text = "Remote";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = remote;
                break;
            case 5:
                item.text = "Gloves";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = gloves;
                break;
            case 6:
                item.text = "Battery";
                rawImage = GetComponent<RawImage>();
                rawImage.texture = battery;
                break;
        }
    }
    
}
