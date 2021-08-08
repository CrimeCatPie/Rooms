using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    [SerializeField] private BoxCollider player;

    private void OnTriggerEnter(Collider other)
    {
        if (other == player)
        {
            var scene = RandomScene.GetScene();
            SceneManager.LoadScene(scene);
        }
    }
}
