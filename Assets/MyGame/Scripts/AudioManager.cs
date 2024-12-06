using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Ein Array von Sounds, das alle verf�gbaren Sounds mit ihren Eigenschaften speichert
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
            // Zerst�rt den aktuellen GameObject, falls bereits ein AudioManager existiert
            Destroy(gameObject);
            return;
        }

        // Verhindert, dass der AudioManager beim Szenenwechsel zerst�rt wird
        DontDestroyOnLoad(gameObject);

        // Initialisiert die AudioSource-Komponenten f�r jedes Sound-Objekt im Array
        foreach (Sounds oneSound in sounds)
        {
            // F�gt eine AudioSource-Komponente zum GameObject hinzu
            oneSound.audioSource = gameObject.AddComponent<AudioSource>();

            // �bertr�gt die Sound-Eigenschaften auf die AudioSource
            oneSound.audioSource.clip = oneSound.clip;         // Zuweisung des AudioClips
            oneSound.audioSource.volume = oneSound.volume;     // Lautst�rke
            oneSound.audioSource.pitch = oneSound.pitch;       // Tonh�he
        }
    }

    // Methode, um eine AudioSource anhand des Namens zu finden
    public AudioSource FindAudio(string name)
    {
        // Iteriert �ber alle Sounds im Array
        foreach (Sounds oneSound in sounds)
        {
            // �berpr�ft, ob der Name mit dem gesuchten �bereinstimmt
            if (oneSound.name == name)
            {
                return oneSound.audioSource; // Gibt die zugeh�rige AudioSource zur�ck
            }
        }
        return null; // Gibt null zur�ck, falls kein passender Sound gefunden wurde
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

