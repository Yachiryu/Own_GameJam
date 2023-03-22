using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class TaxesPuntos : MonoBehaviour
{
    public int moneyCount;
    private TextMeshProUGUI textMesh;

    void Start()
    {
        textMesh = GetComponent<TextMeshProUGUI>();
    }
    private void Update()
    {
        textMesh.text = moneyCount.ToString("Dinero : 0");
    }
}
