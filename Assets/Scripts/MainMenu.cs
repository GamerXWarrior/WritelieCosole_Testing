using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public Dropdown rowDropDown;
    public Dropdown columnDropDown;
    public TextMeshProUGUI playButton;
    public static int rowNum;
    public static int columnNum;
    private int minCount = 2;

    private void Start()
    {
        rowDropDown.onValueChanged.AddListener(delegate { SetRowCount(rowDropDown); });
        columnDropDown.onValueChanged.AddListener(delegate { SetColumnCount(columnDropDown); });
    }

    public void LoadGame()
    {
        SceneManager.LoadScene(1);
    }

    public void SetRowCount(Dropdown row)
    {
        rowNum = row.value + minCount;
        Debug.Log(rowNum);
    }

    public void SetColumnCount(Dropdown column)
    {
        columnNum = column.value + minCount;
        Debug.Log(columnNum);
    }
}
