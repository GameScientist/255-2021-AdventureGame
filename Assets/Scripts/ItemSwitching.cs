using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSwitching : MonoBehaviour
{
    public Text item;
    public int equipped;

    private void Start()
    {
        EquipItem(0);
    }

    public void EquipItem(int itemId)
    {
        equipped = itemId;
        switch (itemId)
        {
            case 0:
                item.text = "Observe";
                break;
            case 1:
                item.text = "Gum";
                break;
            case 2:
                item.text = "Toenail";
                break;
            case 3:
                item.text = "Shoelace";
                break;
            case 4:
                item.text = "Remote";
                break;
            case 5:
                item.text = "Rubber Gloves";
                break;
            case 6:
                item.text = "Battery";
                break;
        }
    }
    
}
