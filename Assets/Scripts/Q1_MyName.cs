using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q1_MyName : MonoBehaviour //Q1c

{
    public string nameOfStudent = "Elsa"; //Q1e
    private int A = 1, B = 2; //Q1k

    public Q1_MyName(string nameOfStudent, int a, int b)
    {
        this.nameOfStudent = nameOfStudent;
        A = a;
        B = b;
    }


    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(nameOfStudent); //Q1f
        Debug.Log("and my student number is"); //Q1i
        Debug.Log("503403"); //Q1d

        //Q1h Name does not change once program is started as Start function is only called once.
        //Q1j debug statements rearranged to make sense in console

       //Q1m Code to display change of variables int A & int B
        Debug.Log("A" + A + "B" + B);
        SwitchAandB();
        Debug.Log("A" + A + "B" + B);
        SwitchAandB();
        Debug.Log("A" + A + "B" + B);

    }

    void SwitchAandB() //Q1I method to switch A & B
    {
        int C; //Local Variable

        C = B;
        B = A;
        A = C;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
