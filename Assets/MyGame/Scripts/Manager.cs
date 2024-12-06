using UnityEngine;

public class Manager : MonoBehaviour
{
    // Prefab, das instanziert werden soll (z. B. ein Platzhalter-Objekt oder ein visueller Marker)
    [SerializeField] private GameObject prefab;

    // Das übergeordnete GameObject, unter dem die instanzierten Objekte als Kinder organisiert werden
    public GameObject parent;

    // Anzahl der Reihen und Spalten, die das Layout bestimmen
    private int rows = 4;   // Anzahl der Reihen
    private int columns = 5; // Anzahl der Spalten

    // Abstand zwischen den einzelnen Objekten im Layout
    private float spacing = 110f;

    // Wird beim Start des Spiels aufgerufen (einmalig)
    void Start()
    {
        // Schleife über die Spalten
        for (int i = 0; i < columns; i++)
        {
            // Schleife über die Reihen
            for (int j = 0; j < rows; j++)
            {
                // Berechnung der Position des Objekts basierend auf der aktuellen Spalte und Reihe
                Vector2 position = new Vector2(i * spacing, j * spacing);

                // Erstellen (Instantiieren) des Objekts an der berechneten Position
                GameObject obj = Instantiate(prefab, position, Quaternion.identity, parent.transform);

                // Sicherstellen, dass das Objekt korrekt dem übergeordneten GameObject (Parent) zugewiesen wird
                obj.transform.SetParent(parent.transform);
            }
        }
    }
}
