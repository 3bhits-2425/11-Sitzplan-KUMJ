using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Ein Array von Sounds, das alle verfügbaren Sounds mit ihren Eigenschaften speichert
    [SerializeField] private Sounds[] sounds;

    // Singleton-Referenz, um sicherzustellen, dass nur ein AudioManager existiert
    private AudioManager singleton;

    private void Awake()
    {
        // Sicherstellen, dass nur ein AudioManager in der Szene existiert
        if (singleton == null)
        {
            singleton = this; // Weist die aktuelle Instanz zu
        }
        else
        {
            // Zerstört den aktuellen GameObject, falls bereits ein AudioManager existiert
            Destroy(gameObject);
            return;
        }

        // Verhindert, dass der AudioManager beim Szenenwechsel zerstört wird
        DontDestroyOnLoad(gameObject);

        // Initialisiert die AudioSource-Komponenten für jedes Sound-Objekt im Array
        foreach (Sounds oneSound in sounds)
        {
            // Fügt eine AudioSource-Komponente zum GameObject hinzu
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();

            // Überträgt die Sound-Eigenschaften auf die AudioSource
            oneSound.audioSource.clip = oneSound.clip;         // Zuweisung des AudioClips
            oneSound.audioSource.volume = oneSound.volume;     // Lautstärke
            oneSound.audioSource.pitch = oneSound.pitch;       // Tonhöhe
        }
    }

    // Methode, um eine AudioSource anhand des Namens zu finden
    public AudioSource FindAudio(string name)
    {
        // Iteriert über alle Sounds im Array
        foreach (Sounds oneSound in sounds)
        {
            // Überprüft, ob der Name mit dem gesuchten übereinstimmt
            if (oneSound.name == name)
            {
                return oneSound.audioSource; // Gibt die zugehörige AudioSource zurück
            }
        }
        return null; // Gibt null zurück, falls kein passender Sound gefunden wurde
    }

    // Methode zum Abspielen eines Sounds basierend auf seinem Namen
    public void managerPlay(string name)
    {
        FindAudio(name)?.Play(); // Spielt die AudioSource ab, falls gefunden
    }

    // Methode zum Pausieren eines Sounds basierend auf seinem Namen
    public void managerPause(string name)
    {
        FindAudio(name)?.Pause(); // Pausiert die AudioSource, falls gefunden
    }

    // Methode zum Stoppen eines Sounds basierend auf seinem Namen
    public void managerStop(string name)
    {
        FindAudio(name)?.Stop(); // Stoppt die AudioSource, falls gefunden
    }
}

