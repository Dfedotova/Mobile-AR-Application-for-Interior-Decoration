using System;
using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    [SerializeField]
    string sceneName;

    public void Load()
    {
        if (gameObject.scene.name == "SampleScene")
            StartCoroutine(LoadNewScene(sceneName));
        else
            StartCoroutine(LoadNewSceneAndUnloadOld(sceneName, gameObject.scene.name));
    }

    public static IEnumerator LoadNewScene(string newSceneName)
    {
        yield return SceneManager.LoadSceneAsync(newSceneName, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(newSceneName));
    }

    public static IEnumerator LoadNewSceneAndUnloadOld(string newSceneName, string oldSceneName)
    {
        yield return SceneManager.LoadSceneAsync(newSceneName, LoadSceneMode.Additive);
        Debug.LogError("I am changed");
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(newSceneName));
        yield return new WaitForEndOfFrame();
        SceneManager.UnloadSceneAsync(oldSceneName);
    }

    public static IEnumerator SwitchBackToMainScene(string newSceneName, string oldSceneName, Action action)
    {
        SceneManager.SetActiveScene(SceneManager.GetSceneByName(newSceneName));
        yield return new WaitForEndOfFrame();
        SceneManager.UnloadSceneAsync(oldSceneName);
        action();
    }
}
