using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
    public GameObject textBox;

    public void ClickButton()
    {
        GlobalCookieCounters.cookieCount += 1; // does the click! every one..
    }

}
