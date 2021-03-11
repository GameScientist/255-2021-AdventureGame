using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Changes opacity depending on if the player is hovering over an interactable item or not.
/// </summary>
public class Reticle : MonoBehaviour
{
    public float opacity = 0.8f; // The opacity of the reticle.
    private Image reticle; // The sprite used to represent the reticle.

    private void Start()
    {
        reticle = GetComponent<Image>();
    }

    private void Update()
    {
        reticle.color = Color.white * opacity;
    }
}
