using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataCubeBehaviour : MonoBehaviour
{
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        float startTime = Random.Range(0.0f, audioSource.clip.length);
        float pitch = Random.Range(-3.0f, 1.0f);
        audioSource.time = startTime;
        audioSource.pitch = pitch;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.z <= 80.0f && transform.position.z >= 50.0f) {
            transform.position = transform.position + new Vector3(0, -0.1f, -0.1f);
        } else {
            transform.position = transform.position + new Vector3(0, 0, -0.1f);
        }
    }
}
