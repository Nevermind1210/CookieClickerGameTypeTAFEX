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
    public static int pogValue = 25;
    public static bool turnOffButton = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPog = GlobalCashCounters.cashCount;
        fakeText.GetComponent<TextMeshProUGUI>().text = "Bot Spam -" + pogValue + " bits";
        realText.GetComponent<TextMeshProUGUI>().text = "Bot Spam -" + pogValue + " bits";
        if (currentPog >= 25)
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
