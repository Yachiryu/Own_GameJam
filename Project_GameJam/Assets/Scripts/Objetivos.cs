using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class Objetivos : MonoBehaviour
{
    public int cantBasura;
    public TextMeshProUGUI textBasura;
    public GameObject canvaObjetivos;

    //PlayerInteractions playerInteractions;

    private void Start()
    {
        //playerInteractions = GetComponent<PlayerInteractions>();

        cantBasura = GameObject.FindGameObjectsWithTag("Basura").Length;
        /*textBasura.text = "Obten las esferas rojas" +
                            "\n Restantes: " + cantBasura;*/
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            canvaObjetivos.SetActive(true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            canvaObjetivos.SetActive(false);
        }

        CantidadBasura();

    }
   /* private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Basura")
        {
            Destroy(collision.transform.parent.gameObject);
            cantBasura--;
            textBasura.text = "obten las esferas rojas" +
                                "\n Restantes: " + cantBasura;

            if (cantBasura <=0)
            {
                textBasura.text = "Recogiste las bolas :)";
                
            }
        }
    }*/
    public void CantidadBasura() 
    {
        textBasura.text = "Recoge la basura y metela al contenedor" +
                          "\nRestantes: " + cantBasura;

        if (cantBasura <= 0)
        {
            textBasura.text = "Basura recogida";

        }
    }


    // Recoger los platos 
    // Recoger la ropa 
    // Recoger la basura
}
