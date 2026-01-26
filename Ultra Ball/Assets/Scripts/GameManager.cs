using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Collectible[] coins;
    public int coinsCollected;
    public TMP_Text coinsText;
    private bool isSceneLoaded = false;
    public AudioSource bgm;

    // Start is called before the first frame update
    void Start()
    {
        coins = FindObjectsOfType<Collectible>();
        coinsText.text = coinsCollected.ToString("00") + " / " + coins.Length.ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (isSceneLoaded)
            {
                StartCoroutine(UnloadSettings());
            }
            else
            {
                StartCoroutine(LoadSettings());
            }
        }
    }

    public void CollectCoin() 
    {
        coinsCollected++;
        coinsText.text = coinsCollected.ToString("00") + " / " + coins.Length.ToString("00");
    }

    public bool CheckCoins() 
    {
        if (coinsCollected == coins.Length)
        {
            return true;
        }

        return false;
    }

    public void Levels()
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

    IEnumerator LoadSettings()
    {   
        AsyncOperation asyncLoad = SceneManager.LoadSceneAsync("Settings", LoadSceneMode.Additive);
        yield return asyncLoad;

        SceneManager.SetActiveScene(SceneManager.GetSceneByName("Settings"));
        
        Time.timeScale = 0f;
        bgm.Pause(); // Pause before loading
        isSceneLoaded = true;
    }
    IEnumerator UnloadSettings()
    {
        AsyncOperation asyncUnload = SceneManager.UnloadSceneAsync("Settings");
        yield return asyncUnload;

        isSceneLoaded = false;
        
        Time.timeScale = 1f;
        bgm.UnPause();
    }
}


