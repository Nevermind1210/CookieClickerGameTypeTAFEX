using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoClicker : MonoBehaviour
{
    public bool CreatingClicks = false;
    public static int ClickIncrease = 1;
    public int InternalIncrease;

    void Update()
    {
        ClickIncrease = GlobalPog.pogsPerSec;
        InternalIncrease = ClickIncrease;
        if (CreatingClicks == false)
        {
            CreatingClicks = true;
            StartCoroutine(CreateTheClick());
        }
    }

    IEnumerator CreateTheClick()
    {
        GlobalCookieCounters.cookieCount += InternalIncrease;
        yield return new WaitForSeconds(1); // Waiting every second to plus 1 count.
        CreatingClicks = false;
    }
        
}
