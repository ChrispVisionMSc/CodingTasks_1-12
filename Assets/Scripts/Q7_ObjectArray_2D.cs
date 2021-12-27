using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q7_ObjectArray_2D : MonoBehaviour
{
    public GameObject prefab01; //Q7a create reference to prefab in Unity inspector



    // Start is called before the first frame update
    void Start()
    {
        //Q7b Instantiate prefab at position (0,1,0) with zero rotation
        Instantiate(prefab01, new Vector3(0, 1, 15), Quaternion.identity);

        //Q7c Instantiate row of 5 prefabs with 10% spacing between            
        for (int i = 0; i < 5; i++)
        {
            Instantiate(prefab01, new Vector3(i * 1.1f, 1, 10), Quaternion.identity);
        }
        
        //Q7d Instantiate 5 x 5 grid of prefabs with 10% spacing
      for (int i = 0; i < 5; i++)      
        {
            for (int j = 0; j < 5; j++)
            {
                Instantiate(prefab01, new Vector3(i * 1.1f, 1, j * 1.1f), Quaternion.identity);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
