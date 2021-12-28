using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q5_EnumLoopMethods : MonoBehaviour
{
    public TMPro.TMP_Text Q5d, Q5e, Q5f;

    public enum LoopMethodOptions { HardCoded, ForLoop, WhileLoop, DoWhile, Recursive, UpdateFrameMethod };
    public LoopMethodOptions loopMethodMenu;

    public int loopNumber = 5;

    //Variables for UpdateFrameMethod & UpdateFrameDelay
    private int UpdateFrameI = 0;
    private string UpdateFrameStringTemp;
    private int TargetLoop;


    // Update is called once per frame
    void Update()
    {
        Q5d.text = HardCoded();//example of hard coding a repeating method

        Q5e.text = loopMethodMenu.ToString();//Displays selected enum option name in TMPro text box
        Q5f.text = LoopMethods();
    }

    public string LoopMethods()//Calls different loop methids depending on Loop Method Menu selection in Unity inspector
    {
        if (LoopMethodOptions.HardCoded == loopMethodMenu) return HardCoded();
        if (LoopMethodOptions.ForLoop == loopMethodMenu) return ForLoop();
        if (LoopMethodOptions.WhileLoop == loopMethodMenu) return WhileLoop();
        if (LoopMethodOptions.DoWhile == loopMethodMenu) return DoWhile();
        if (LoopMethodOptions.Recursive == loopMethodMenu) return Recursive(loopNumber);
        //if (LoopMethodOptions.UpdateFrameMethod == loopMethodMenu) return UpdateFrameMethod();

        else return "";
    }

    public string HardCoded()// Used only to demostrate why looping methods were established.
    {
        return "HelloWorld HardCode\n"
            + "HelloWorld HardCode\n"
            + "HelloWorld Hardcode\n"
            + "HelloWorld HardCode\n"
            + "HelloWorld HardCode\n";
    }

    public string ForLoop()// Useful for initialisation, checking & updating conditions
    {
        string Temp = "";

        for (int iCount = 1; iCount <= loopNumber; iCount++)
        {
            Temp = Temp + iCount.ToString() + "HelloWorld ForLoop\n".ToString();
        }
        return Temp;
    }

    public string WhileLoop()// While loop checks condition before iteration
                             // but will only start and continue if condition permits.
    {
        string Temp = "";
        int iCount = 1;

        while (iCount <= loopNumber)
        {
            Temp = Temp + iCount.ToString() + "HelloWorld WhileLoop\n".ToString();
            iCount++;
        }

        return Temp;
    }

    public string DoWhile()// Do While loop will start regardless of conditions
                           // and then check conditions to determine stop or continue (to be used with caution).
    {
        string Temp = "";
        int iCount = 1;

        do
        {
            Temp = Temp + iCount.ToString() + "HelloWorld DoLoop\n".ToString();
            iCount++;
        }
        while (iCount <= loopNumber);

        return Temp;
    }


    public string Recursive(int iCount)// Recursive loops used for processing of extensiv tasks like 'Tower of Hanoi' or where data set size is not known.
    //loopNumber is defined when Recursive() is called from line 30
    {
        if (iCount <= 0) return "";

        string Temp = Recursive(iCount - 1) + iCount.ToString() + "HelloWorld Recursive\n".ToString();

        return Temp;
    }

    public string UpdateFrameMethod()//Update Frame Loops used to decouple update rate from processor speeds or screen refresh rates.
        //See variables to support method on lines 15,16 & 17
    {
        if(TargetLoop != loopNumber)
        {
            //See variables to support method on lines 15,16 & 17
            TargetLoop = loopNumber;
            UpdateFrameI = 0;
            UpdateFrameStringTemp = "";// To clear buffer variable each time loopNumber is changed
        }
        if (UpdateFrameI >= loopNumber) return UpdateFrameStringTemp;
        else
        {
            UpdateFrameI++;
            UpdateFrameStringTemp = UpdateFrameStringTemp + UpdateFrameI.ToString() + "HelloWorld UpdateFrame\n".ToString();
            return UpdateFrameStringTemp;
        }

    }
    /*public string UpdateFrameMethodDelay()//Limited use but useful for updating complex graphics at screen refresh rate e.g 60Hz
    {
        string Temp = "UpdateFrameMethodDelay";
        //your code here
        return Temp;
    }*/







}   
