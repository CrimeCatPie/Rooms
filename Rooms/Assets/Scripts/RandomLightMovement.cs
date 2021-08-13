using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomLightMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float positionZ = (float)System.Math.Round(Random.Range(-1.0f, 1.0f), System.MidpointRounding.AwayFromZero);
        float positionX = (float)System.Math.Round(Random.Range(-1.0f, 1.0f), System.MidpointRounding.AwayFromZero);
        var newPositionZ = transform.position + new Vector3(0, 0, positionZ);
        var newPositionX = transform.position + new Vector3(positionX, 0, 0);
        if (newPositionZ.z >= -17 && newPositionZ.z <= 17) {
            transform.position = newPositionZ;
        }
        if (newPositionX.x >= -17 && newPositionX.x <= 17) {
            transform.position = newPositionX;
        }
    }
}
