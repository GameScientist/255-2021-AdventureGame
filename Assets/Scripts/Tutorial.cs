using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Shows narration and plays sound when the player lands on the ground when starting the scene.
/// </summary>
public class Tutorial : MonoBehaviour
{
    public Narration narration; // The narration that appears when the script is activated.

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) narration.DisplayText("tutorial");
        FindObjectOfType<AudioManager>().Play("Oof");
        FindObjectOfType<AudioManager>().Play("Landing");
    }
}
