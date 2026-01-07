using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goal : MonoBehaviour
{
    public GameObject center;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(FindObjectOfType<GameManager>().CheckCoins())
        {
            center.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (FindObjectOfType<GameManager>().CheckCoins()) 
        {
            Debug.Log("uhaJAFJDvjhwFHWEh");
            int nextScene = SceneManager.GetActiveScene().buildIndex + 1;
            if (nextScene <= SceneManager.sceneCount)
            {
                SceneManager.LoadScene(nextScene);
            }
        }
        
    }
}
