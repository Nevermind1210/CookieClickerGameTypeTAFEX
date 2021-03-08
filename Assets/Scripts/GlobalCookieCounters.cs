using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; // Access to UI Elements.

using TMPro;

public class GlobalCookieCounters : MonoBehaviour
{
    public static int cookieCount; // this can be accessed from any script.
    public GameObject cookieDisplayCount; // as it says.
    public int cookiesInternal; // to show in inspector how much cookies exist in realtime.

    void Update()
    {
        cookiesInternal = cookieCount; 
        cookieDisplayCount.GetComponent<TextMeshProUGUI>().text = "Cookies: " + cookiesInternal;
    }
}
