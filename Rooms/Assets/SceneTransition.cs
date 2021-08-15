using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTransition : SwapScenes
{
    [SerializeField] private Animator image;

    void Update()
    {
        if (IsTriggered == true)
        {
            FadeToNextScene();
        }
        
    }

    public void FadeToNextScene()
    {
        image.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        var scene = RandomScene.GetScene();
        SceneManager.LoadScene(scene);
        IsTriggered = false;
    }
}
