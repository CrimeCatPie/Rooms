using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractalBehaviour : MonoBehaviour
{ 
    Material material;
    private static string ColliderName = "DataCube";
    // Start is called before the first frame update
    void Awake()
    {
        material = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == ColliderName) {
            material.SetColor("_EmissionColor", new Color(1.91f,0.0f,0.0f,0.0f));
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == ColliderName) {
            material.SetColor("_EmissionColor", new Color(0.0f,0.0f,0.0f,-1.0f));
        }
    }
}
