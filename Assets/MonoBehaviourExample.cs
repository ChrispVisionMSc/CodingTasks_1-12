using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonoBehaviourExample : MonoBehaviour
{
    //Awake is called as soon as the program starts
    void Awake()
    {
        Debug.Log ("Awake"); //Q1b-i
    }



    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Started"); //Q1b-ii

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Update"); //Q1b-iii
    }

    private void FixedUpdate()
    {
        Debug.Log("Fixed Update"); //Q1b-iv
    }

    //Q1b-v Each function is called in order from top to bottom
}
