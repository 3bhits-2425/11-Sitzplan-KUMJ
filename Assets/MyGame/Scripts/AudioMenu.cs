using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    [SerializeField] private AudioSource myAudioSource; // Ensure this is assigned or has an AudioSource component on the GameObject.
    [SerializeField] private GameObject playPauseButton; // Serialized field for the button

    private TMP_Text playPauseButtonText;

    void Awake()
    {
        myAudioSource = GetComponent<AudioSource>();

        // Check if myAudioSource is assigned
        if (myAudioSource == null)
        {
            UnityEngine.Debug.LogError("AudioSource component is missing from the GameObject!");
        }

        if (playPauseButton == null)
        {
            UnityEngine.Debug.LogError("playPauseButton is not assigned in the Inspector!");
        }
        else
        {
            // Find the TMP_Text component as a child of playPauseButton
            playPauseButtonText = playPauseButton.GetComponentInChildren<TMP_Text>();
            if (playPauseButtonText == null)
            {
                UnityEngine.Debug.LogError("Could not find TMP_Text component in the playPauseButton's children!");
            }
        }
    }

    public void PlayAudio()
    {
        // Spiele die Audio-Source 
        if (myAudioSource != null)
        {
            myAudioSource.Play();
        }
    }

    public void PauseAudio()
    {
        // Pausiere die Audio-Source
        if (myAudioSource != null)
        {
            myAudioSource.Pause();
        }
    }

    public void StopAudio()
    {
        // Stoppe die Audio-Source
        if (myAudioSource != null)
        {
            myAudioSource.Stop();
        }
    }

    public void PlayPause()
    {
        if (myAudioSource != null && playPauseButtonText != null)
        {
            if (myAudioSource.isPlaying)
            {
                myAudioSource.Pause();
                playPauseButtonText.text = "Play";
                UnityEngine.Debug.Log("Audio paused");
            }
            else
            {
                myAudioSource.Play();
                playPauseButtonText.text = "Pause";
                UnityEngine.Debug.Log("Audio playing");
            }
        }
    }

    public void Update()
    {
        // Null checks before trying to access properties
        if (myAudioSource == null || playPauseButtonText == null)
        {
            UnityEngine.Debug.LogWarning("myAudioSource or playPauseButtonText is null in Update()");
            return;
        }

        // Ändere den Button-Text abhängig vom Zustand der AudioSource
        if (myAudioSource.isPlaying)
        {
            playPauseButtonText.text = "Pause";
        }
        else
        {
            playPauseButtonText.text = "Play";
        }
    }
}
