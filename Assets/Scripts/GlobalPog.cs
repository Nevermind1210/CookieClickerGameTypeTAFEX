using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access to UI Elements.

using TMPro;

public class GlobalPog : MonoBehaviour
{
    public GameObject fakeButton;
    public GameObject fakeText;
    public GameObject realText;
    public GameObject realButton;
    public int currentPog;
    public static int pogValue = 3;
    public static bool turnOffButton = false;
    public GameObject pogStats;
    public static int numberOfPogggers;
    public static int pogsPerSec;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPog = GlobalCashCounters.cashCount;
        pogStats.GetComponent<TextMeshProUGUI>().text = "Poggers Spamming:" + numberOfPogggers + " @ " + pogsPerSec + " per second";
        fakeText.GetComponent<TextMeshProUGUI>().text = "Bot Spam -" + pogValue + " bits";
        realText.GetComponent<TextMeshProUGUI>().text = "Bot Spam -" + pogValue + " bits";
        if (currentPog >= pogValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }
        if (turnOffButton == true)
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
