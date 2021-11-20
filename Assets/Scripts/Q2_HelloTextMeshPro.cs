using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q2_HelloTextMeshPro : MonoBehaviour //Q2a
{
    public TMPro.TMP_Text text_display;
    public string TheName = "Type Name Here";

    // Start is called before the first frame update
    void Start()
    {
        text_display.text = TheName;
    }

    // Update is called once per frame
    void Update()
    {
        text_display.text = TheName; //Q2c
    }
}
