using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SettingsPage : MonoBehaviour
{
    public GameObject sound;
    public GameObject controls;
    public GameObject howto;
    
    public void toggleSound()
    {
       sound.SetActive(true);
       controls.SetActive(false);
       howto.SetActive(false);
    }
    public void toggleControls()
    {
       controls.SetActive(true);
       sound.SetActive(false);
       howto.SetActive(false);
    }
    public void toggleHowTo()
    {
       howto.SetActive(true);
       sound.SetActive(false);
       controls.SetActive(false);
    }
}
