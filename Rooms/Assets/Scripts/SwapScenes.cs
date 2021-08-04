using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScenes : MonoBehaviour
{
    void Start()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        var scene = RandomScene.GetScene();
        Debug.Log(scene);
        SceneManager.LoadScene(scene);
    }
}
