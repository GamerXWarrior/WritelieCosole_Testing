using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GridManager : MonoBehaviour
{
    [SerializeField] CardsRow[] cardsRows;
    [SerializeField] GameObject rowPrefab;

    private RectTransform gridTransform;
    private GridLayoutGroup grid;
    private int rowCount;
    private int minCount = 2;
    private int columnCount;
    private float cellSize;
    public CardCell cellPref;
    private List<List<CardCell>> myList = new List<List<CardCell>>();

    private void Awake()
    {
        rowCount = MainMenu.rowNum;
        if (rowCount < minCount)
            rowCount = minCount;

        columnCount = MainMenu.columnNum;
        if (columnCount < minCount)
            columnCount = minCount;
    }

    private void Start()
    {
        CreateCells();
    }

    private void CreateCells()
    {
   

        cardsRows = new CardsRow[rowCount];
        for (int i = 0; i < rowCount; i++)                        
        {
            Debug.Log("for loop ount: " + i);

            GameObject singleRow = Instantiate(rowPrefab);
            CardsRow row = singleRow.transform.GetComponent<CardsRow>();
            singleRow.transform.SetParent(this.transform, false);
            cardsRows[i] = row;
            row.Init(columnCount, cellPref.gameObject);
            //GameObject percentObj = Instantiate(cellPref.gameObject, singleRow.transform);
            ////_percentageHolder[i] = percentObj.GetComponent<Image>();
            //percentObj.transform.SetParent(singleRow.transform, false);
            //percentObj.transform.SetAsLastSibling();
            //paletteCells.Add(rowList);
        }
    }
}
