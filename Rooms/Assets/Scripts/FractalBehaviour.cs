using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FractalBehaviour : MonoBehaviour
{ 
    Material material;
    AudioSource audioSource;
    private static string ColliderName = "DataCube(Clone)";
    // Start is called before the first frame update
    void Awake()
    {
        material = GetComponent<Renderer>().material;
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other) {
        if (other.name == ColliderName) {
            float red = 1.55f;
            float green = Random.Range(0.02f, 0.6f);
            float blue = Random.Range(0.02f, 0.09f);
            material.SetColor("_EmissionColor", new Color(red, green, blue, -0.0f));
            float pitch = Random.Range(-1.0f, 2.0f);
            audioSource.pitch = pitch;
            audioSource.Play();
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.name == ColliderName) {
            material.SetColor("_EmissionColor", new Color(0.0f,0.0f,0.0f,-1.0f));
            audioSource.Pause();
        }
    }
}
