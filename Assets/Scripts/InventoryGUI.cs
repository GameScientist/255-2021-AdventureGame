using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Inventory icons are displayed based on if they have been stored in the player's inventory.
/// </summary>
public class InventoryGUI : MonoBehaviour
{
    // The inventory icons.
    public Transform gum;
    public Transform toenail;
    public Transform shoelace;
    public Transform Remote;
    public Transform rubberGloves;
    public Transform batttery1;
    public Transform batttery2;
    public Transform batttery3;

    // Update is called once per frame
    void Update() // The icons will appear if the player has them in their inventory.
    {
        gum.gameObject.SetActive(Inventory.main.hasGum);
        toenail.gameObject.SetActive(Inventory.main.hasToenail);
        shoelace.gameObject.SetActive(Inventory.main.hasShoelace);
        Remote.gameObject.SetActive(Inventory.main.hasRemote);
        rubberGloves.gameObject.SetActive(Inventory.main.hasRubberGloves);
        batttery1.gameObject.SetActive(Inventory.main.hasBattery1);
        batttery2.gameObject.SetActive(Inventory.main.hasBattery2);
        batttery3.gameObject.SetActive(Inventory.main.hasBattery3);
    }

    
}
