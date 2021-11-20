using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld5 : MonoBehaviour
{
    public TMPro.TMP_Text Q5ac;
    public enum MethodOption { HardCoded, ForLoop, WhileLoop, DoWhile, Recursive, UpdateFrameMethod, UpdateFrameMethodDelay}
    public MethodOption MethodSelected;
    public float FrameDelayInSeconds;
    public int Loop = 5;
    

    //updated frame method
    private int UpdateFrameI = 0;
    private string UpdateFrameStringTemp;
    private float LastFrameUpdate;
    private int TargetLoop;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Q5ac.text = LoopHelloWorld();
    }

    public string LoopHelloWorld()
    {
        if (MethodOption.HardCoded == MethodSelected) return HardCoded();
        if (MethodOption.ForLoop == MethodSelected) return ForLoop();
        if (MethodOption.WhileLoop == MethodSelected) return WhileLoop();
        if (MethodOption.DoWhile == MethodSelected) return DoWhileLoop();
        if (MethodOption.Recursive == MethodSelected) return Recursive(Loop);
        if (MethodOption.UpdateFrameMethod == MethodSelected) return UpdateFrameMethod();
        if (MethodOption.UpdateFrameMethodDelay == MethodSelected) return UpdateFrameMethodDelay();
        return "No Implemented";
    }

    public string HardCoded()
    {
        return "Hello World \n"
                   + "Hello World \n"
                   + "Hello World \n"
                   + "Hello World \n"
                   + "Hello World \n"
                    +"Hello World \n";
    }
    public string ForLoop()
    {
        string Temp = "";
        for (int i = 1; i <= Loop; i++)
        {
            Temp = Temp + i.ToString() + "Hello World \n".ToString();
        }
        return Temp;
    }
    public string WhileLoop()
    {
        string Temp = "";
        int i = 1;
        while (i <= Loop)
        {
            Temp = Temp + i.ToString() + "Hello World \n".ToString();
            i++;
        }
        return Temp;
    }
    public string DoWhileLoop()
    {
        // Local variable declaration:
        int i = 1;
        string Temp = "";
        // do loop execution
        do
        {
            Temp = Temp + i.ToString() + "Hello World \n".ToString();
            i = i + 1;
        } while (i < Loop);

        return Temp;
    }
    public string Recursive(int i) //5
    {
        if (i <= 0) return "";
        int j = i - 1; //4
        string Temp = Recursive(j) + i.ToString() + "Hello World \n".ToString(); // Temp ="1HelloWorld\n2HelloWorld\n3HelloWorld\n4HelloWorld\n" + i.ToString() + "Hello World \n".ToString();
        return Temp;
    }
    public string UpdateFrameMethod()
    {
        if (TargetLoop != Loop)
        {
            TargetLoop = Loop;
            UpdateFrameI = 0;
            UpdateFrameStringTemp = "";
        } 
        if (UpdateFrameI >= Loop) return UpdateFrameStringTemp;
        else
        {
            UpdateFrameI++;
            UpdateFrameStringTemp = UpdateFrameStringTemp + UpdateFrameI.ToString() + "Hello World \n".ToString();
            return UpdateFrameStringTemp;
        }
    }
    public string UpdateFrameMethodDelay()
    {
        if (TargetLoop != Loop)
        {
            TargetLoop = Loop;
            UpdateFrameI = 0;
            UpdateFrameStringTemp = "";
        }
        if (UpdateFrameI >= Loop) return UpdateFrameStringTemp;
        else
        {
            if (LastFrameUpdate > FrameDelayInSeconds)
            {
                LastFrameUpdate = 0.0f;
                UpdateFrameI++;
                UpdateFrameStringTemp = UpdateFrameStringTemp + UpdateFrameI.ToString() + "Hello World \n".ToString();
                return UpdateFrameStringTemp;
            }
            else
            {
                LastFrameUpdate = LastFrameUpdate + Time.deltaTime;
                return UpdateFrameStringTemp;
            }
        }
    }

}
