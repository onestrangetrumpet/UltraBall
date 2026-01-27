using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VolumeSlider : MonoBehaviour
{
    public Slider musicSlider;
    public Slider SFXSlider;
    public Slider masterSlider;

    void Start()
    {
        float musicdB = PlayerPrefs.GetFloat("MusicVolume", 0f);
        musicSlider.onValueChanged.AddListener(MusicChanged);

        float sfxdB = PlayerPrefs.GetFloat("SFXVolume", 0f);
        SFXSlider.onValueChanged.AddListener(SFXChanged);

        float masterdB = PlayerPrefs.GetFloat("MasterVolume", 0f);
        masterSlider.onValueChanged.AddListener(MasterChanged);

        float musicNormalized = Mathf.Pow(10f, musicdB / 20f);
        float sfxNormalized = Mathf.Pow(10f, sfxdB / 20f);
        float masterNormalized = Mathf.Pow(10f, masterdB / 20f);

        musicSlider.value = musicNormalized;
        SFXSlider.value = sfxNormalized;
        masterSlider.value = masterNormalized;
    }

    void MusicChanged(float value)
    {
        Volume.Instance.SetMusicVolume(value);
    }
    void SFXChanged(float value)
    {
        Volume.Instance.SetSFXVolume(value);
    }
    void MasterChanged(float value)
    {
        Volume.Instance.SetMasterVolume(value);
    }

}
