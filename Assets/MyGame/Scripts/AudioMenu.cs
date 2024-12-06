using System;
using TMPro; // Für die TextMeshPro-Komponente
using UnityEngine;

public class AudioMenu : MonoBehaviour
{
    // Referenz auf die Audioquelle, die gesteuert wird
    [SerializeField] private AudioSource myAudiosource;

    // Referenz auf den Button, der die Audio-Steuerung ermöglicht
    [SerializeField] private GameObject ToggleAudioButton;

    // Text-Komponente des Buttons (wird verwendet, um den Text zwischen "Play" und "Stop" umzuschalten)
    private TMP_Text playPauseButtonText;

    // Wird beim Initialisieren des GameObjects aufgerufen
    void Awake()
    {
        // AudioSource-Komponente des aktuellen GameObjects finden
        myAudiosource = GetComponent<AudioSource>();

        // Sucht nach einem GameObject mit dem Namen "ToggleButton"
        ToggleAudioButton = GameObject.Find("ToggleButton");

        // Holt die TMP_Text-Komponente des Buttons (der Text, der angezeigt wird)
        playPauseButtonText = ToggleAudioButton.GetComponentInChildren<TMP_Text>();
    }



    // Methode zum Abspielen des Audios
    public void PlayAudio()
    {
        // Spielt den Sound ab
        // myAudiosource.Play();

        // Alternativ: Ruft die Funktion eines AudioManagers auf, um "test" abzuspielen
        FindAnyObjectByType<AudioManager>().managerPlay("test");
    }

    // Methode zum Pausieren des Audios
    public void PauseAudio()
    {
        // Pausiert den Sound
        // myAudiosource.Pause();

        // Alternativ: Ruft die Pause-Funktion eines AudioManagers auf
        FindAnyObjectByType<AudioManager>().managerPause("test");
    }

    // Methode zum Stoppen des Audios
    public void ResetAudio()
    {
        // Stoppt den Sound
        // myAudiosource.Stop();

        // Alternativ: Ruft die Stop-Funktion eines AudioManagers auf
        FindAnyObjectByType<AudioManager>().managerStop("test");
    }

    // Methode, um den Audiozustand zwischen Play und Pause umzuschalten
    public void ToggleAudio()
    {
        if (myAudiosource.isPlaying)
        {
            // Wenn Audio abgespielt wird, wird es pausiert
            FindAnyObjectByType<AudioManager>().managerPause("test");
            playPauseButtonText.text = "Start"; // Button zeigt "Start" an
        }
        else
        {
            // Wenn Audio pausiert ist, wird es abgespielt
            FindAnyObjectByType<AudioManager>().managerPlay("test");
            playPauseButtonText.text = "Stop"; // Button zeigt "Stop" an
        }
    }

    // Wird jeden Frame aufgerufen (aktuell auskommentiert, könnte aber verwendet werden)
    public void Update()
    {
        // Dynamische Aktualisierung des Button-Textes basierend auf dem Zustand der Audioquelle
        // if (myAudiosource.isPlaying)
        // {
        //     playPauseButtonText.text = "Stop"; // Wenn Audio abgespielt wird, soll "Stop" angezeigt werden
        // }
        // else
        // {
        //     playPauseButtonText.text = "Play"; // Wenn Audio pausiert ist, soll "Play" angezeigt werden
        // }
    }
}
