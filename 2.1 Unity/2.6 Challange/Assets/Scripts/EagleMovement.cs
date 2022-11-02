using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EagleMovement : MonoBehaviour
{
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemySpeed = 1 * Time.deltaTime;
        transform.Translate(new Vector3(0, enemySpeed, 0));
    }
}
