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
        InternalIncrease = ClickIncrease; // will increase when purchases 1 * 2;
        if (CreatingClicks == false)
        {
            CreatingClicks = true;
            StartCoroutine(CreateTheClick()); // Will add every second.
        }
    }

    IEnumerator CreateTheClick()
    {
        GlobalPogCounters.pogCount += InternalIncrease;
        yield return new WaitForSeconds(1); // Waiting every second to plus 1 count.
        CreatingClicks = false;
    }

}
