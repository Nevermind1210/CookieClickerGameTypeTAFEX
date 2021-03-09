using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access to UI Elements.

using TMPro;

public class GlobalCashCounters : MonoBehaviour
{
    public static int cashCount; // this can be accessed from any script.
    public GameObject cashDisplayCount; // as it says.
    public int cashInternal; // to show in inspector how much cookies exist in realtime.

    void Update()
    {
        cashInternal = cashCount;
        cashDisplayCount.GetComponent<TextMeshProUGUI>().text = "Komodohypes made: " + cashInternal;
    }
}
