using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collectible : MonoBehaviour

{
    public AudioSource CoinSound;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        CoinSound.Play();
        FindObjectOfType<GameManager>().CollectCoin();
        Destroy(this.gameObject);
    }

}
