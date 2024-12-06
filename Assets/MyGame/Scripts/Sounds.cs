using UnityEngine.Audio;
using UnityEngine;
[System.Serializable]   // Markiert die Klasse als serialisierbar, sodass sie in Unity-Inspektor sichtbar ist


//Klass for sounds.
public class Sounds {
 // Public Variablen definieren
    public string name;
    // Dies soll später erweitert werden
    public AudioClip clip;

    /*
        Zusätzlicher Kommentar:
        AudioSource wird während der Laufzeit zugewiesen, 
        um Audioclips abzuspielen und zu steuern.
    */

    [Range(0f,1f)] 
    public float volume;
    [Range(0.1f, 3f)] 
    public float pitch;

    // Versteckt die Variable im Unity-Inspektor, da sie programmintern genutzt wird
    [HideInInspector] 
    public AudioSource audioSource;
}
