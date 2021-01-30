using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    private float time = 0;
    public Text text;
    private bool timerStarted = false;
    public Transform panel;
    private int intTime;
    public Battery battery1;
    public Battery battery2;
    public Battery battery3;
    public Inventory inventory;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (timerStarted)
        {
            time -= Time.deltaTime;
            intTime = (int)time;
            text.text = "Charge: "  + intTime;
            if (time <= 0)
            {
                timerStarted = false;
                panel.gameObject.SetActive(false);
                battery1.Respawn();
                battery2.Respawn();
                battery3.Respawn();
                inventory.batteries = 0;
            }
        }
    }

    public void TimeTrial()
    {
        time = 20;
        panel.gameObject.SetActive(true);
        timerStarted = true;
    }
}
