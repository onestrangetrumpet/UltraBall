using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPreferences : MonoBehaviour
{    
    public string Settings;
    void Start()
    {
        StartCoroutine(LoadAndUnloadRoutine(Settings));
    }

    IEnumerator LoadAndUnloadRoutine(string Settings)
    {
        // --- 1. Load the scene additively ---
        // Use LoadSceneMode.Additive to keep the current scene loaded
        AsyncOperation loadOperation = SceneManager.LoadSceneAsync(Settings, LoadSceneMode.Additive);

        // Wait until the loading operation is complete
        while (!loadOperation.isDone)
        {
            yield return null;
        }

        Debug.Log(Settings + " loaded.");

        // Optional: Perform actions with the loaded scene contents here (e.g., extract data)

        // --- 2. Unload the scene ---
        // Use UnloadSceneAsync to remove the scene
        AsyncOperation unloadOperation = SceneManager.UnloadSceneAsync(Settings);

        // Wait until the unloading operation is complete
        while (!unloadOperation.isDone)
        {
            yield return null;
        }

        Debug.Log(Settings + " unloaded.");
    }
}
