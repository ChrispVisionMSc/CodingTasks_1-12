using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Q7_ObjectArray_3D : MonoBehaviour
{
    public GameObject prefab01; //Q7a create reference to prefab in Unity inspector

    //Diminsions of object 3D array with initial value of 5 x 5 x 5 units
    public int units_x = 5;
    public int units_y = 5; 
    public int units_z = 5;

    public Renderer rendererA;//Q7f Varible derived from mesh renderer class of GameObject

    [SerializeField] private Vector3 size;//Q7f Vector3 array to store bounds dimensions Height, Width, Length
    

    // Start is called before the first frame update
    void Start()
    {

        rendererA = prefab01.GetComponent<Renderer>();//Q7f Gets mesh renderer data from prefab

        // Q7f Bounds function takes maximum external dimensions height, width & depth of mesh renderer data
        size = rendererA.bounds.size;

        //Q7e Instantiate 5x5x5 3D grid of prefabs with 10% spacing
        //Q7f Units x y & z can be adjusted through inspector to determine number of prefabs initiated in 3D array.
        for (int i = 0; i <units_x; i++)
        {
            for (int j = 0; j < units_y; j++)

                for(int k = 0; k < units_z; k++)
            {
                Instantiate(prefab01, new Vector3(i * 1.1f*size[0], j * 1.1f*size[1], k * 1.1f*size[2]), Quaternion.identity);
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }
}
