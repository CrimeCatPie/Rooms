using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private BoxCollider playerCollider;
    [SerializeField] private bool first, second, third;

    void Start()
    {
        playerCollider = player.GetComponent<BoxCollider>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other == playerCollider)
        { 
            if (first == true)
                SceneManager.LoadScene("Room2");
            
            if (second == true)
                SceneManager.LoadScene("Room3");

            if (third == true)
                SceneManager.LoadScene("Room1");

        }
    }
}
