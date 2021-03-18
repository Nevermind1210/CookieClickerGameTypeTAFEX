using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access to UI Elements.

using TMPro;

public class GlobalPogCounters : MonoBehaviour
{
    public static int pogCount; // this can be accessed from any script.
    public GameObject pogDisplayCount; // as it says.
    public int poggersInternal; // to show in inspector how much cookies exist in realtime.

    void Update()
    {
        poggersInternal = pogCount; 
        pogDisplayCount.GetComponent<TextMeshProUGUI>().text = "Pogs in chat: " + poggersInternal;
    }
}
