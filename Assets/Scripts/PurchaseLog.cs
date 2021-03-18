using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoClicker;
    public AudioSource playSound;

    public void StartAutoClicker()
    {
        playSound.Play();
        AutoClicker.SetActive(true);
        GlobalCashCounters.cashCount -= GlobalPog.bitValue;
        GlobalPog.bitValue *= 2;
        GlobalPog.turnOffButton = true;
    }
}
