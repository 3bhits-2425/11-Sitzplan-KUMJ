using UnityEngine;

// Mit diesem Attribut wird eine Option im Unity-Asset-Menü erstellt, 
// um ein neues ScriptableObject für Studentendaten zu erzeugen.
[CreateAssetMenu(fileName = "StudentData", menuName = "Sitzplan/Student", order = 1)]

public class StudentData : ScriptableObject
{
    // Der vollständige Name des Schülers/der Schülerin
    public string studentName;

    // Die Augenfarbe des Schülers/der Schülerin, verwendbar für visuelle Darstellungen
    public Color eyeColor;

    // Ein Bild (Sprite), das den Schüler/die Schülerin repräsentiert (z. B. ein Profilbild)
    public Sprite studentImage;

    // Ein AudioClip, der beispielsweise die Stimme des Schülers/der Schülerin enthält
    public AudioClip studentClip;
}
