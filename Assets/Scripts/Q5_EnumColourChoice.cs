using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q5_EnumColourChoice : MonoBehaviour
{
    public TMPro.TMP_Text Q5a, Q5b;

    public enum ColourOptions { black, white, blue, green, choice };
    public ColourOptions ColourMenu;
    public Color ColorChoice;


    // Update is called once per frame
    void Update()
    {
        Q5a.text = ColourMenu.ToString();
        Q5b.text = ColourMenu.ToString();
        Q5b.color = ColorLookUp(ColourMenu);
    }

    public Color ColorLookUp(ColourOptions chosenOption)//Q5b
    {
        if (chosenOption == ColourOptions.black) return Color.black;
        if (chosenOption == ColourOptions.white) return Color.white;
        if (chosenOption == ColourOptions.blue) return Color.blue;
        if (chosenOption == ColourOptions.green) return Color.green;
        if (chosenOption == ColourOptions.choice) return ColorChoice;//Static Method?
        else return Color.magenta;

    }
}
