using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerPreferences : MonoBehaviour
{    
    private bool isSceneLoaded = false;
    void Start()
    {   
        isSceneLoaded = true;
        SceneManager.LoadScene("Settings");

        if (isSceneLoaded)
        {
            SceneManager.UnloadSceneAsync("Settings");
        }
    }
}
