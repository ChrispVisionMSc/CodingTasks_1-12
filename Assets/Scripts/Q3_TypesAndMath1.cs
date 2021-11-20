using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q3_TypesAndMath1 : MonoBehaviour
{
    public TMPro.TMP_Text text_display;


    // Start is called before the first frame update
    void Start()
    {
        //Q3a
        text_display.text = "10/3 = " + (10.0f / 3.0f).ToString(); 

        //Q3b
        Debug.Log((2 + "bc").ToString());
        Debug.Log((2 + 3 + "bc").ToString());
        Debug.Log(((2 + 3) + "bc").ToString());
        Debug.Log(("bc" + (2 + 3)).ToString());
        Debug.Log(("bc" + 2 + 3).ToString());
        //Demonstrates what order variables such as strings and ints get added together
        //as program runs.

        
        //Q3c
        int LargestNumber = int.MaxValue;

        Debug.Log(LargestNumber.ToString());
        Debug.Log((LargestNumber + 1).ToString());
        Debug.Log((2-LargestNumber).ToString());
        Debug.Log((-2-LargestNumber).ToString());
        Debug.Log((2*LargestNumber).ToString());
        Debug.Log((4*LargestNumber).ToString());
        //Demonstrates Overflow Errors

        //Q3d

        Debug.Log((Mathf.Sqrt(2.0f) * Mathf.Sqrt(2.0f) == 2.0f).ToString());
        //Equality statement returns 'False' when it should be true??
        //Square root of 2 is infinite number so creates overlow error??






    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
