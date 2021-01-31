using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Camera))] // tells Unity, this script NEEDS to work.
public class Raycaster : MonoBehaviour
{
    private Camera cam;
    public Transform player;
    public Transform telport;
    public Narration narration;

    // Start is called before the first frame update
    void Start()
    {
        cam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        // Fire a ray into the screen.

        if (cam != null && Input.GetButtonDown("Fire1"))
        { // Did the user click on this game tick?
            if (ItemSwitching.main.equipped == 4)
            {
                if (Inventory.main.batteries == 3)
                {
                    SceneManager.LoadScene("Credits");
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

            if (Physics.Raycast(ray, out hit)) // raycast hit a collider in the scene!
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
    }
}
