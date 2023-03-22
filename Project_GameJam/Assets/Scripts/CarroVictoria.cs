using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroVictoria : MonoBehaviour
{
    Objetivos objetivos;
    MenuManager menuManager;
    private void Start()
    {
        objetivos = FindObjectOfType<Objetivos>();
        menuManager = FindObjectOfType<MenuManager>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && objetivos.objetivosCumplidos)
        {
            menuManager.Win();
        }
    }
}
