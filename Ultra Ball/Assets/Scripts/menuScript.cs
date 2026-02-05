using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuScript : MonoBehaviour
{        public void Levels()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Play()
    {
        SceneManager.LoadScene("Level_01");
    }
    public void Settings()
    {
        SceneManager.LoadScene("Settings");
    }
    public void Menu()
    {
        SceneManager.LoadScene("Menu");
    }
}
