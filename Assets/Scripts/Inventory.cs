using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    public static Inventory _main;

    public static Inventory main
    {
        get { return _main; }
    }

    public bool hasRemote = false;
    public bool hasBattery1 = false;
    public bool hasBattery2 = false;
    public bool hasBattery3 = false;
    public int batteries = 0;

    // Start is called before the first frame update
    private void Start()
    {
        if (_main == null)
        {
            _main = this;
            DontDestroyOnLoad(gameObject);
            // don't destroy this object when loading new scenes
        }
        else
        {
            Destroy(gameObject); // destroy this extra inventory system...
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (batteries == 3)
        {
            hasBattery3 = true;
        }

        if (batteries == 2)
        {
            hasBattery2 = true;
        }

        if (batteries == 1)
        {
            hasBattery1 = true;
        }
    }

}
