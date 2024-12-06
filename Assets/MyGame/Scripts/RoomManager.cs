using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomManager : MonoBehaviour
{
    // Referenzen für das Layout und die Prefabs
    [SerializeField] private TableLayoutData tableLayout; // Layout-Daten für die Tische
    [SerializeField] private GameObject tablePrefab;      // Prefab für Tisch
    [SerializeField] private GameObject rightChairPrefab; // Prefab für rechten Stuhl
    [SerializeField] private GameObject leftChairPrefab;  // Prefab für linken Stuhl

    void Start()
    {
        if (tableLayout == null)
        {
            UnityEngine.Debug.LogError("TableLayoutData ist nicht zugewiesen! Bitte im Inspector hinzufügen.");
            return;
        }
        if (tablePrefab == null)
        {
            UnityEngine.Debug.LogError("TablePrefab ist nicht zugewiesen! Bitte im Inspector hinzufügen.");
            return;
        }
        if (rightChairPrefab == null)
        {
            UnityEngine.Debug.LogError("RightChairPrefab ist nicht zugewiesen! Bitte im Inspector hinzufügen.");
            return;
        }
        if (leftChairPrefab == null)
        {
            UnityEngine.Debug.LogError("LeftChairPrefab ist nicht zugewiesen! Bitte im Inspector hinzufügen.");
            return;
        }

        // Wenn alles zugewiesen ist, kann die Logik sicher ausgeführt werden
        UnityEngine.Debug.Log("Alle Referenzen korrekt zugewiesen. Starte Sitzplan-Generierung.");
        // Sitzplan-Logik hier...

        // Erstelle Tische und Stühle basierend auf dem Layout
        for (int row = 0; row < tableLayout.rows; row++)
        {
            for (int col = 0; col < tableLayout.columns; col++)
            {
                // Position des Tisches berechnen
                Vector3 tablePosition = new Vector3(col * tableLayout.tableSpacing, 0, row * tableLayout.tableSpacing);

                // Tisch instanziieren
                GameObject table = Instantiate(tablePrefab, tablePosition, Quaternion.identity, transform);

                // Positionen der Stühle berechnen
                Vector3 leftChairPosition = tablePosition + new Vector3(-0.5f, 0, 1);  // Linker Stuhl
                Vector3 rightChairPosition = tablePosition + new Vector3(0.5f, 0, 1); // Rechter Stuhl

                // Linken Stuhl instanziieren
                Instantiate(leftChairPrefab, leftChairPosition, Quaternion.identity, transform);

                // Rechten Stuhl instanziieren
                Instantiate(rightChairPrefab, rightChairPosition, Quaternion.identity, transform);
            }
        }

        UnityEngine.Debug.Log("Tische und Stühle wurden erfolgreich generiert!");
    }
}
