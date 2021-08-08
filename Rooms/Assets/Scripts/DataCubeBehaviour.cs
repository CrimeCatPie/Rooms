using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCubeBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 80.0f && transform.position.z >= 50.0f) {
            transform.position = transform.position + new Vector3(0, -0.2f, -0.2f);
        } else {
            transform.position = transform.position + new Vector3(0, 0, -0.2f);
        }
    }
}
