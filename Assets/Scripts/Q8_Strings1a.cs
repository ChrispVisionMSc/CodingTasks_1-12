using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace StringToCharArrayMethods { }

public class Q8_Strings1a : MonoBehaviour
{
    public TMPro.TMP_Text input_display, output_display;
    public string stringIn = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    //char[] charArray = stringIn.ToCharArray();
    

    // Start is called before the first frame update
    void Start()
    {
        input_display.text = "Input String: " + stringIn.ToString();
       
    }

    // Update is called once per frame
    void Update()
    {
        input_display.text = "Input String: " + stringIn.ToString();
       
    }
}
