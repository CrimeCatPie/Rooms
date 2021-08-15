using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HallPortalBehaviour : MonoBehaviour
{
    [SerializeField] public string scene;
    [SerializeField] private BoxCollider player;

    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
