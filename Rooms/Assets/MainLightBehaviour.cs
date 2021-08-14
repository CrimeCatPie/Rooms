using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainLightBehaviour : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    private bool appearanceState = true;

    void Update()
    {
        if (Time.time > nextActionTime ) {
            nextActionTime += Random.Range(0.0f, 1.0f);
            appearanceState = !appearanceState;
            GetComponent<Light>().intensity = appearanceState ? 1 : 0;
            float randomX = Random.Range(0.0f, 35.0f);
            float randomY = Random.Range(120.0f, 240.0f);
            transform.Rotate(randomX, randomY, 0);
        }
    }
}
