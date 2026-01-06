using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public Collectible[] coins;
    public int coinsCollected;
    public TMP_Text coinsText;

    // Start is called before the first frame update
    void Start()
    {
        coins = FindObjectsOfType<Collectible>();
        coinsText.text = coinsCollected.ToString("00") + " / " + coins.Length.ToString("00");
    }

    // Update is called once per frame
    void Update()
    {
        
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
}
