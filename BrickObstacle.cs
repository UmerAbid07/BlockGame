using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrickObstacle : MonoBehaviour
{

    public GameObject brickPrefab;
    int randomIndex;
    public float startInvokeTime = 2f;
    public float repeatInvokeTime = 2f;
    float brickCountPerSpawn = 4f;
    public Vector3 position;
    int[] ar = new int[4] ;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("invokeGameObject", startInvokeTime, repeatInvokeTime);
    }

    // Update is called once per frame
    
    void invokeGameObject()
    {
        for (int i = 0; i <brickCountPerSpawn; i++)
        {
            //at which position the obstacle will be spawned
            
            position = new Vector3(8 * ar[i], 0, 0);
            Instantiate(brickPrefab, transform.position - position, transform.rotation);
            
        }
        arrayDecleration();
    }
    void arrayDecleration()
    {
        for(int i =0; i < ar.Length;i++)
        {
            randomIndex = Random.Range(0, 5);
            ar[i] = randomIndex;
            if (ar[i] == ar[i - 1])
            {
                randomIndex = Random.Range(0, 5);
                ar[i] = randomIndex;
            }
        }
    }
}
