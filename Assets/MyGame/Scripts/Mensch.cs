using System.Collections;
using System.Collections.Generic;
using System.Diagnostics; // Wird wahrscheinlich nicht ben�tigt, wenn du nur UnityEngine Debug verwenden m�chtest
using UnityEngine;
using UnityEngine.UI;

public class Mensch : MonoBehaviour
{
    public string personName;
    public string rolleInKlasse;
    public Color augenfarbe;

    [SerializeField]
    private AudioSource myAudioSource;

    // Start is called before the first frame update
    void Start()
    {
        UnityEngine.Debug.Log("Mein Name: " + personName);
        UnityEngine.Debug.Log("Meine Rolle: " + rolleInKlasse);
        UnityEngine.Debug.Log("Meine Augenfarbe: " + augenfarbe);

        myAudioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        // Sobald die Leertaste gedr�ckt wird
        if (Input.GetKeyDown(KeyCode.Space))
        {
            UnityEngine.Debug.Log("Leertaste gedr�ckt");
            myAudioSource.Play();
        }
        else if (Input.GetKeyUp(KeyCode.Space))
        {
            UnityEngine.Debug.Log("Leertaste losgelassen");
            myAudioSource.Pause();
        }
    }
}
