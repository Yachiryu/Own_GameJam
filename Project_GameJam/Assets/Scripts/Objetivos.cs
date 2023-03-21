using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class Objetivos : MonoBehaviour
{
    public int numObjetivos;
    public TextMeshProUGUI textoMision;
    //public GameObject botonMision;

    private void Start()
    {
        numObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
        textoMision.text = "Obten las esferas rojas" +
                            "\n Restantes: " + numObjetivos;
    }

    private void Update()
    {
        
    }
    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Objetivo")
        {
            Destroy(col.transform.parent.gameObject);
            numObjetivos--;
            textoMision.text = "obten las esferas rojas" +
                                "\n Restantes: " + numObjetivos;

            if (numObjetivos <=0)
            {
                textoMision.text = "Recogiste las bolas :)";
                
            }
        }
    }

    // Recoger los platos 
    // Recoger la ropa 
    // Recoger la basura
}
