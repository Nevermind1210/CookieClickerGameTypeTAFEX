using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoBits : MonoBehaviour
{
    public bool CreatingBits = false;
    public static int BitsIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        BitsIncrease = GlobalBits.bitsPerSec; 
        InternalIncrease = BitsIncrease; // will increase when purchases 1 * 2;
        if (CreatingBits == false)
        {
            CreatingBits = true;
            StartCoroutine(CreateTheBits()); // Will add every second.
        }
    }

    IEnumerator CreateTheBits()
    {
        if (GlobalCookieCounters.cookieCount == 0)
        {

        }
        else
        {
            GlobalCashCounters.cashCount += InternalIncrease;
            GlobalCookieCounters.cookieCount -= 1;
            yield return new WaitForSeconds(1); // Waiting every second to plus 1 count.
            CreatingBits = false;
        }
    }
}
