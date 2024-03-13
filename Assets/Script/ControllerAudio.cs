using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControllerAudio : MonoBehaviour
{
    public Slider volumeSlider;
    public AudioClip audioClip;
    private AudioSource audioSource;

    void Start()
    {
        
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.clip = audioClip; 
        volumeSlider.value = audioSource.volume;
        audioSource.Play();
    }

    public void SetVolume(float volume)
    {
        audioSource.volume = volume;
    }
}