using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoneBehaviour : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    void Update()
    {
        if (Time.time > nextActionTime ) {
            nextActionTime += Random.Range(1.0f, 5.0f);
            float speedX = Random.Range(-5.0f, 5.0f);
            float speedY = Random.Range(-5.0f, 5.0f);
            float speedZ = Random.Range(-5.0f, 5.0f);

            GetComponent<Rigidbody>().velocity = new Vector3(speedX, speedY, speedZ);
        }
    }
}
