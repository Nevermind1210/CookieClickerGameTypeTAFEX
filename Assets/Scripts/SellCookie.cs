using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using TMPro;
public class SellCookie : MonoBehaviour
{
    public GameObject textBox;
    public GameObject statusBox;

    public void ClickButton()
    {
        if (GlobalCookieCounters.cookieCount == 0)
        {
            statusBox.GetComponent<TextMeshProUGUI>().text = "You can't trade no pogs for komonodohype! Make more!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalCookieCounters.cookieCount -= 1;
            GlobalCashCounters.cashCount += 1;
        }
    }
}
