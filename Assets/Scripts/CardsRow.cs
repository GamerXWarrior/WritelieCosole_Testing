using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CardsRow : MonoBehaviour
{
    [SerializeField]
    private CardCell[] rowCells;
    [SerializeField]
    private GameObject cellPrefab;

    public void Init(int columnSize, GameObject cellPrefab)
    {
        //correctNumberOfColors = 0;
        rowCells = new CardCell[columnSize];
        for (int i = 0; i < columnSize; i++)
        {
            Debug.Log("column loop count: " + i);
            GameObject cellObj = Instantiate(cellPrefab, transform);

            rowCells[i] = cellObj.GetComponent<CardCell>();
            Debug.Log("row array length at init: " + rowCells.Length);
        }
    }
}
