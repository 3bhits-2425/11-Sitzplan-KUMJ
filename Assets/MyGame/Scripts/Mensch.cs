using UnityEngine;

public class Mensch : MonoBehaviour
{
    [SerializeField] private AudioSource myAudiosource;
    public string personName;
    public string rolleInKlasse;
    public Color augenFarbe;

    void Start()
    {
        // Verwende UnityEngine.Debug explizit, um Verwirrung zu vermeiden
        UnityEngine.Debug.Log("Mein Name: " + personName + " Rolle: " + rolleInKlasse + " Augenfarbe: " + augenFarbe);
        myAudiosource = GetComponent<AudioSource>();
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myAudiosource.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            myAudiosource.Pause();
        }
    }
}
