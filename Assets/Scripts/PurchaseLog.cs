using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PurchaseLog : MonoBehaviour
{
    public GameObject AutoClicker;
    public GameObject AutoBits;
    public AudioSource playSound;

    public void StartAutoClicker()
    {
        playSound.Play();
        AutoClicker.SetActive(true);
        GlobalCashCounters.cashCount -= GlobalPog.bitValue;
        GlobalPog.bitValue *= 2;
        GlobalPog.turnOffButton = true;
        GlobalPog.pogsPerSec += 1;
        GlobalPog.numberOfPogggers += 1;
    }
    public void StartAutoBits()
    {
        playSound.Play();
        AutoBits.SetActive(true);
        GlobalCashCounters.cashCount -= GlobalPog.bitValue;
        GlobalBits.bitValue *= 2;
        GlobalBits.turnOffButton = true;
        GlobalBits.bitsPerSec += 1;
        GlobalBits.numberOfBits += 1;
    }
}
