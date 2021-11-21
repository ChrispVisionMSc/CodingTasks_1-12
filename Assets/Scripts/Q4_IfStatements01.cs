using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q4_IfStatements01 : MonoBehaviour
{
    //TextMesh Pro references to link variables and code outputs -
    //to Text Mesh objects in Unity Scene.
    public TMPro.TMP_Text Atext, Btext;
    public TMPro.TMP_Text Q4a, Q4b, Q4c, Q4d, Q4e, Q4f, Q4g;
    public TMPro.TMP_Text textBoolC, textBoolD, textBoolE;
    public TMPro.TMP_Text textDoubleF, textDoubleG, textDoubleH;

    public int A, B;
    public bool C, D, E;
    public float F, G, H;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Atext.text = "Int A = " + A.ToString();
        Btext.text = "Int B = " + B.ToString();
        Q4a.text = "Q4a, Is A smaller than B? = " + (A < B).ToString();
        Q4b.text = "Q4b, Is A larger than B? = " + (A > B).ToString();
        Q4c.text = "Q4c, Is A or B divisible by the other = " + (A % B == 0 || B % A == 0).ToString();
        Q4d.text = "Q4d, Is A an even number? = " + (A % 2 == 0).ToString();

        textBoolC.text = "bool C = " + C.ToString();
        textBoolD.text = "bool D = " + D.ToString();
        textBoolE.text = "bool E = " + E.ToString();
        Q4e.text = "Q4e, Odd number bool true? = " + oddInputsTrue(C, D, E).ToString();
        Q4f.text = "Q4f, Majority number bool true? = " + majorityInputTrue(C, D, E).ToString();

        textDoubleF.text = "double F = " + F.ToString();
        textDoubleG.text = "double G = " + G.ToString();
        textDoubleH.text = "double H = " + H.ToString();
        Q4g.text = "Q4g, Can F,G,H be sides of a triangle? = " + triangularTest(F, G, H).ToString();
    }

    //Q4e Function (static method) that takes three Boolean inputs and returns true -
    //if odd number of inputs is true.
    static public bool oddInputsTrue(bool a, bool b, bool c)
    {
        return a ^ b ^ c; //Using exclusive OR (XOR) operator

        //Hard code method, limited as logic has to be rewritten for additional inputs
        /*
        if (a && b && c) return true;
        if (a && !b && !c) return true;
        if (!a && b && c) return true;
        if (!a && !b && c) return true;
        else return false;
        */
    }


    //Q4f Function (static method) that takes three Boolean inputs and returns true -
    //if majority of inputs is true.
    static public bool majorityInputTrue(bool a, bool b, bool c)
    {
        int count = 0; //local int to record count increment each time a bool is true

        if (a) count++;
        if (b) count++;
        if (c) count++;
        if (count > 1) return true;
        else return false;
        
        //Hard code method, limited as logic has to be rewritten for additional inputs
        /*
        if (a && b && c) return true;
        if (!a && b && c) return true;
        if (a && !b && c) return true;
        if (a && b && !c) return true;
        return false;
        */ 
    }


    //Q4g Function (static method) checks three float inputs to determine if lengths -
    //would be suitable for construction of a triangle.
    static public bool triangularTest(float a, float b, float c)
    {
        if (Mathf.Abs(a * b * c) < 0.000001f) return false; //Use Mathf.Abs to disregard negative numbers.
        if (b + c >= a) return true;
        if (a + c >= b) return true;
        if (b + a >= c) return true;
        return false; 
    }
}
