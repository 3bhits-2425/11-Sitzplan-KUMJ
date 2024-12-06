using UnityEngine;

// Mit diesem Attribut wird eine Option im Unity-Asset-Men� erstellt, 
// um ein neues ScriptableObject f�r Studentendaten zu erzeugen.
[CreateAssetMenu(fileName = "StudentData", menuName = "Sitzplan/Student", order = 1)]

public class StudentData : ScriptableObject
{
    // Der vollst�ndige Name des Sch�lers/der Sch�lerin
    public string studentName;

    // Die Augenfarbe des Sch�lers/der Sch�lerin, verwendbar f�r visuelle Darstellungen
    public Color eyeColor;

    // Ein Bild (Sprite), das den Sch�ler/die Sch�lerin repr�sentiert (z. B. ein Profilbild)
    public Sprite studentImage;

    // Ein AudioClip, der beispielsweise die Stimme des Sch�lers/der Sch�lerin enth�lt
    public AudioClip studentClip;
}
