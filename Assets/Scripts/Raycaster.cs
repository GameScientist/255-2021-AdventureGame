using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
[RequireComponent(typeof(Camera))] // tells Unity, this script NEEDS to work.
public class Raycaster : MonoBehaviour
{
    private Camera cam;

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
            if (ItemSwitching.main.equipped == 4 && Inventory.main.batteries == 3)
            {
                SceneManager.LoadScene("Credits");
            }

            Ray ray = new Ray(cam.transform.position, cam.transform.forward);
            RaycastHit hit;

            //????
            Debug.DrawRay(ray.origin, ray.direction, Color.black, .5f);

            if (Physics.Raycast(ray, out hit)) // raycast hit a collider in the scene!
            {

                Battery battery = hit.transform.GetComponentInParent<Battery>();
                if (battery != null)
                {
                    battery.PlayerInteract();
                }
            }

        }
    }
}
