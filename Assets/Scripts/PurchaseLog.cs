using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoClicker;

    public void StartAutoClicker()
    {
        AutoClicker.SetActive(true);
        GlobalCashCounters.cashCount -= GlobalPog.pogValue;
        GlobalPog.pogValue *= 2;
        GlobalPog.turnOffButton = true;
    }
}
