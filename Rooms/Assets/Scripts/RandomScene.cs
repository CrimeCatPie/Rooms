using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System.Linq;

public static class RandomScene
{
    public static Dictionary<string, bool> SceneDictionary = InitializeSceneDictionary();

    private static Dictionary<string, bool> InitializeSceneDictionary()
    {
        var sceneCount = SceneManager.sceneCountInBuildSettings;
        var sceneDictionary = new Dictionary<string, bool>();
        for (int index = 0; index < sceneCount; index++) {
            string pathToScene = SceneUtility.GetScenePathByBuildIndex(index);
            string sceneName = Path.GetFileNameWithoutExtension(pathToScene);
            sceneDictionary.Add(sceneName, false);
        }

        return sceneDictionary;
    }

    public static string GetScene()
    {
        string selectedSceneName = "";
        var scenesCount = SceneDictionary.Count;
        int randomIndex = 0;
        while (selectedSceneName.Length == 0) {
            randomIndex = (int)System.Math.Round(Random.Range(0.0f, scenesCount - 1.0f), System.MidpointRounding.AwayFromZero);
            var key = SceneDictionary.ElementAt(randomIndex).Key;
            if (SceneDictionary[key] == false) {
                selectedSceneName = key;
            }
        }
        foreach (KeyValuePair<string, bool> item in SceneDictionary.ToList()) {
            if (item.Key == selectedSceneName) {
                SceneDictionary[item.Key] = true;
            } else {
                SceneDictionary[item.Key] = false;
            }
        }
        
        return selectedSceneName;
    }
}
