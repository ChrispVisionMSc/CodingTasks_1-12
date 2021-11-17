using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeArgs : MonoBehaviour //Q2d
{
    public TMPro.TMP_Text text_display;

    public string First = " Angela ";
    public string Second = " Maria ";
    public string Third = " Riley ";

    // Start is called before the first frame update
    void Start()
    {
        text_display.text = "Hello" + "," + First + "," + Second + "," + Third; //Q2d
    }

    // Update is called once per frame
    void Update()
    {
        text_display.text = "Hello" + "," + First + "," + Second + "," + Third; //Q2e
    }
}
