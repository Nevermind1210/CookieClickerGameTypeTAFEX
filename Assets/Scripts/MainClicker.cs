using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainClicker : MonoBehaviour
{
    public GameObject textBox;

    public void ClickButton()
    {
        textBox.SetActive(true);
    }

}
