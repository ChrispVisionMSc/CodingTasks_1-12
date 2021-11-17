using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloTextMeshPro : MonoBehaviour
{
    public TMPro.TMP_Text text_display;
    public string TheName;

    // Start is called before the first frame update
    void Start()
    {
        text_display.text = TheName;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
