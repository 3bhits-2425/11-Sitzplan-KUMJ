using UnityEngine;

[CreateAssetMenu(fileName = "NewTableLayout", menuName = "Sitzplan/TableLayout", order = 1)]
public class TableLayoutData : ScriptableObject
{
    public int rows;          // Anzahl der Reihen
    public int columns;       // Anzahl der Spalten
    public float tableSpacing; // Abstand zwischen den Tischen

}
