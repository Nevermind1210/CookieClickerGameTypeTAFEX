using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access to UI Elements.

using TMPro;

public class GlobalPog : MonoBehaviour
{
    public GameObject fakeButton; // to show the effect that the button isn't clickable....
    public GameObject fakeText;
    public GameObject realText;
    public GameObject realButton; // the clickable button.
    public int currentPog;
    public static int bitValue = 3; // this changes the text once launched
    public static int pogValue = 3;

    public static bool turnOffButton = false;
    public GameObject pogStats;
    public static int numberOfPogggers;
    public static int pogsPerSec;

    // Start is called before the first frame update
    void Start()
    {
        //Shut up I'll use you later...
    }

    // Update is called once per frame
    void Update()
    {
        currentPog = GlobalCashCounters.cashCount;
        pogStats.GetComponent<TextMeshProUGUI>().text = "Poggers Spamming:" + numberOfPogggers + " @ " + pogsPerSec + " per second"; // string manipulation.
        fakeText.GetComponent<TextMeshProUGUI>().text = "Bot Spam -" + bitValue + " bits";
        realText.GetComponent<TextMeshProUGUI>().text = "Bot Spam -" + bitValue + " bits";
        if (currentPog >= bitValue)
        {
            fakeButton.SetActive(false);
            realButton.SetActive(true);
        }

        if (turnOffButton == true) // as it states
        {
            realButton.SetActive(false);
            fakeButton.SetActive(true);
            turnOffButton = false;
        }
    }
}
