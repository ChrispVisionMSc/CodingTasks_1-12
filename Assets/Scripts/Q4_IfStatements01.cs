using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q4_IfStatements01 : MonoBehaviour
{
    public TMPro.TMP_Text Atext, Btext;

    public TMPro.TMP_Text Q4a, Q4b, Q4c, Q4d, Q4e, Q4f;

    public int A, B;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Atext.text = ("A = " + A.ToString());
        Btext.text = ("B = " + B.ToString());
    }
}
