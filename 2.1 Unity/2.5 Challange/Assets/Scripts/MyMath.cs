using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMath : MonoBehaviour
{
    int num = 1;
    void Start()
    {
        
    }

    void Update()
    {
        int product = num = num * 2;
        Debug.Log(product);
    }
}
