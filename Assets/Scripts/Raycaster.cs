using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

[RequireComponent(typeof(Camera))] // tells Unity, this script NEEDS to work.
public class Raycaster : MonoBehaviour
{
    private Camera cam; // The camera this component is attached to, used to decide what direction to set a raycast to.
    private float maxDistance = 50f; // The maximum length that a raycast can travel.
    public Reticle reticle; // A UI circle that changes opacity depending on if the player is pointing at an item of interest.
    public Narration narration; // The narration that holds the text given if the player tries to use the remote without its batteries.
    public Text footer; // A brief description given to items when the player hovers over them.
    public StaticScreenTransition transition; // Plays when the scene is changed to the credits.
    private float timer = 0f; // How long the transition has been playing for. Used to decide when to begin the scene transition.
    private bool timerActivated = false; // Starts adding to the timer when true.

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        reticle.opacity = 0.6f;
        footer.text = "";

        if (timerActivated)
        {
            timer++;
            if (timer >= 60) SceneManager.LoadScene("Credits");
        }

        // Fire a ray into the screen.
        if (cam != null && Input.GetButtonDown("Fire1"))
        { // Did the user click on this game tick?
            if (ItemSwitching.main.equipped == 4)
            {
                if (Inventory.main.batteries == 3 && !transition.fadingIn)
                {
                    transition.gameObject.SetActive(true);
                    transition.fadingIn = true;
                    timerActivated = true;
                }
                else
                {
                    narration.DisplayText("remoteUse");
                }
            }

            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;

            //????
            Debug.DrawRay(ray.origin, ray.direction, Color.black, .5f);

            if (Physics.Raycast(ray, out hit) && hit.distance <= maxDistance) // raycast hit a collider in the scene!
            {
                Remote remote = hit.transform.GetComponentInParent<Remote>();
                if (remote != null)
                {
                    remote.PlayerInteract();
                }
                
                Battery battery = hit.transform.GetComponentInParent<Battery>();
                if (battery != null)
                {
                    battery.PlayerInteract();
                }

                Hole hole = hit.transform.GetComponentInParent<Hole>();
                if (hole != null)
                {
                    hole.PlayerInteract();
                }

                Gum gum = hit.transform.GetComponentInParent<Gum>();
                if (gum != null)
                {
                    gum.PlayerInteract();
                }

                Toenail toenail = hit.transform.GetComponentInParent<Toenail>();
                if (toenail != null)
                {
                    toenail.PlayerInteract();
                }

                Nail nail = hit.transform.GetComponentInParent<Nail>();
                if (nail != null)
                {
                    nail.PlayerInteract();
                }

                Shoelace shoelace = hit.transform.GetComponentInParent<Shoelace>();
                if (shoelace != null)
                {
                    shoelace.PlayerInteract();
                }
            }

        }

        else
        {
            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;

            //????
            Debug.DrawRay(ray.origin, ray.direction, Color.black, .5f);

            if (Physics.Raycast(ray, out hit) && hit.distance <= maxDistance)
            {
                Remote remote = hit.transform.GetComponentInParent<Remote>();
                if (remote != null)
                {
                    footer.text = "Remote Control";
                    reticle.opacity = 1f;
                }

                Battery battery = hit.transform.GetComponentInParent<Battery>();
                if (battery != null)
                {
                    footer.text = "AAA Battery";
                    reticle.opacity = 1f;
                }

                Hole hole = hit.transform.GetComponentInParent<Hole>();
                if (hole != null)
                {
                    footer.text = "Deep Hole";
                    reticle.opacity = 1f;
                }

                Gum gum = hit.transform.GetComponentInParent<Gum>();
                if (gum != null)
                {
                    footer.text = "Piece of Gum";
                    reticle.opacity = 1f;
                }

                Toenail toenail = hit.transform.GetComponentInParent<Toenail>();
                if (toenail != null)
                {
                    footer.text = "Toenail";
                    reticle.opacity = 1f;
                }

                Nail nail = hit.transform.GetComponentInParent<Nail>();
                if (nail != null)
                {
                    footer.text = "Nail";
                    reticle.opacity = 1f;
                }

                Shoelace shoelace = hit.transform.GetComponentInParent<Shoelace>();
                if (shoelace != null)
                {
                    footer.text = "Shoelace";
                    reticle.opacity = 1f;
                }
            }
        }
    }
}
