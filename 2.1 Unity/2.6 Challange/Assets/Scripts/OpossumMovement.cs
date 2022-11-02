using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpossumMovement : MonoBehaviour
{
    public float enemySpeed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        enemySpeed = -1 * Time.deltaTime;
        transform.Translate(new Vector3(enemySpeed, 0, 0));
    }
}
