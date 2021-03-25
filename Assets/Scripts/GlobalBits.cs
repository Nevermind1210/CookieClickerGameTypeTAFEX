using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access to UI Elements.

using TMPro;

public class GlobalBits : MonoBehaviour
{
    public GameObject fakeButton; // to show the effect that the button isn't clickable....
    public GameObject fakeText;
    public GameObject realText;
    public GameObject realButton; // the clickable button.
    public int currentBits;
    public static int bitValue = 3; // this changes the text once launched
    public static bool turnOffButton = false;
    public GameObject bitsStats;
    public static int numberOfBits;
    public static int bitsPerSec;

    // Update is called once per frame
    void Update()
    {
        currentBits = GlobalCashCounters.cashCount;
        bitsStats.GetComponent<TextMeshProUGUI>().text = "Bits Donated:" + numberOfBits + " @ " + bitsPerSec + " per second"; // string manipulation.
        fakeText.GetComponent<TextMeshProUGUI>().text = "Buy Simps -" + bitValue + " bits";
        realText.GetComponent<TextMeshProUGUI>().text = "Buy Simps -" + bitValue + " bits";
        if (currentBits >= bitValue)
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
