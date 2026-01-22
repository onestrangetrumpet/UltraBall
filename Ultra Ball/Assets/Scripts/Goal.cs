using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject center;
    public AudioSource GoalSound;
    private bool hasPlayed = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().CheckCoins())
        {
            ActivateObject();
            center.SetActive(true);
        }
    }

    public void ActivateObject()
    {
        if (gameObject.activeSelf && !hasPlayed)
        {
            Debug.Log("Object activated, playing sound once!");
            if (GoalSound != null && GoalSound.clip != null)
            {
                GoalSound.Play(); // Play the sound
                hasPlayed = true;   // Set flag to true so it won't play again
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (FindObjectOfType<GameManager>().CheckCoins()) 
        {
            Debug.Log("uhaJAFJDvjhwFHWEh");
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(nextScene);
        }
        
    }
}
