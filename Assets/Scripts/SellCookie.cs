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
        if (GlobalPogCounters.pogCount == 0)
        {
            statusBox.GetComponent<TextMeshProUGUI>().text = "You can't trade no pogs for bits! Make more Pogs!";
            statusBox.GetComponent<Animation>().Play("StatusAnim");
        }
        else
        {
            GlobalPogCounters.pogCount -= 1;
            GlobalCashCounters.cashCount += 1;
        }
    }
}
