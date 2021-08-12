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

        if (transform.position.z > 157 || transform.position.z < 183) {
            transform.position = transform.position + new Vector3(0, 0, positionZ * 0.1f);
        }

        if (transform.position.x > 62 || transform.position.x < 92) {
            transform.position = transform.position + new Vector3(positionX * 0.1f, 0, 0);
        }
    }
}
