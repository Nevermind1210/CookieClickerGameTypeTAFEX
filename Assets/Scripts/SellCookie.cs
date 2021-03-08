using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SellCookie : MonoBehaviour
{
    public GameObject textBox;

    public void ClickButton()
    {
        GlobalCookieCounters.cookieCount -= 1;
        GlobalCashCounters.cashCount += 1;
    }

}
