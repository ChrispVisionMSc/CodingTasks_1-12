using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThreeArgs : MonoBehaviour
{
    public TMPro.TMP_Text text_display;

    public string First = "Angela";
    public string Second = "Maria";
    public string Third = "Riley";

    public string TheName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        text_display.text = TheName;
    }
}
