using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// An animation that is played in between scenes to cover up abrupt changes in visuals.
/// </summary>
public class StaticScreenTransition : MonoBehaviour
{
    private float opacity = 60; // Used to calculate the opacity of the animation.
    private RawImage image; // The static screen used to display the image.
    public bool fadingIn = false; // Determines whether the animation has started building in opacity. If false, the opacity will lessen until it is at 0.
    private RectTransform position; // The position of the static image.
    AudioSource audioSource; // The static sound effect accompaning the transition.
    private bool playingAudio = false; // Used to decide whether to start playing the audio or not.

    // Start is called before the first frame update
    void Start() // Gathering components from the object.
    {
        image = GetComponent<RawImage>();
        position = GetComponent<RectTransform>();
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update() // The illusion of static is given by taking an image of static that is double the size of the screen and gradually increasing and decreasing its opacity while changing the position of the image each frame to make it appear it is changing randomly, just like static from a real TV!
    {
        if (fadingIn)
        {
            opacity++;
            if (!playingAudio)
            {
                audioSource.Play();
                playingAudio = true;
            }
            if(opacity >= 60)fadingIn = false;
        }else
        {
            opacity--;
            if (opacity <= 0)
            {
                opacity = 0;
                audioSource.Stop();
                gameObject.SetActive(false);
            }
        }
        image.color = Color.Lerp(Color.clear, Color.white, opacity/60);
        audioSource.volume = Mathf.Lerp(0f, 1f, opacity/60);

        float x = Random.Range(-960f, 960f);
        float y = Random.Range(-540f, 540f);
        position.anchoredPosition3D = new Vector3(x, y, 0);

    }
}
