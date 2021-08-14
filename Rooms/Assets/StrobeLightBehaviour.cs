using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StrobeLightBehaviour : MonoBehaviour
{
    private float nextActionTime = 0.0f;
    private bool appearanceState = true;
    void Update()
    {
        if (Time.time > nextActionTime ) {
            nextActionTime += Random.Range(0.0f, 2.0f);
            appearanceState = !appearanceState;
            for (int index = 0; index < transform.childCount; index++)
             {
                 transform.GetChild(index).gameObject.SetActive(appearanceState);
             }
        }
    }
}
