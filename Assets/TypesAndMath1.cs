using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TypesAndMath1 : MonoBehaviour
{
    public TMPro.TMP_Text text_display;


    // Start is called before the first frame update
    void Start()
    {
        text_display.text = "10/3 = " + (10f / 3f).ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
