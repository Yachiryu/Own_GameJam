using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarroVictoria : MonoBehaviour
{
    Objetivos objetivos;
    private void Start()
    {
        objetivos = FindObjectOfType<Objetivos>();
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Player" && objetivos.objetivosCumplidos)
        {
            Debug.Log("Ganaste");
        }
    }
}
