using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEditor.UI;

public class Objetivos : MonoBehaviour
{
    public GameObject canvaObjetivos;

    public int cantBasura, cantDinero, cantRopa, cantPlatos, cantIngredentes;
    public TextMeshProUGUI textBasura, textServicios, textRopa, textPlatos, textIngredientes;

    private void Start()
    {
        cantBasura = GameObject.FindGameObjectsWithTag("Basura").Length;
        cantRopa = GameObject.FindGameObjectsWithTag("Ropa").Length;
        cantPlatos = GameObject.FindGameObjectsWithTag("Platos").Length;
        cantIngredentes = GameObject.FindGameObjectsWithTag("Ingrediente").Length;
        
        textRopa.text = "Recoge la ropa para ir a trabajar" +
                                "\n Ropa restante: " + cantRopa;
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
        PagoImpuestos();
        CantidadPlatos();
        CantidadIngredientes();

    }

    public void CantidadBasura() 
    {
        textBasura.text = "Recoge la basura y metela al contenedor" +
                          "\nRestantes: " + cantBasura;

        if (cantBasura <= 0)
        {
            textBasura.text = "Basura recogida";

        }
    }
    public void PagoImpuestos()
    {
        textServicios.text = "Consigue los 500 dolares de la hipoteca";

        if (cantDinero >= 9)
        {
            textServicios.text = "Dinero conseguido";
        }
    }
    public void CantidadPlatos()
    {
        textPlatos.text = "Recoge los platos" +
                          "\nRestantes: " + cantPlatos;

        if (cantPlatos <= 0)
        {
            textPlatos.text = "Platos Recogidos";

        }
    }
    public void CantidadIngredientes()
    {
        textIngredientes.text = "¡Arma tu almuerzo!" +
                          "\nRestantes: " + cantIngredentes;

        if (cantIngredentes <= 0)
        {
            textIngredientes.text = "Almuerzo listo";

        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ropa")
        {
            Destroy(collision.gameObject);
            cantRopa--;
            textRopa.text = "Recoge la ropa para ir a trabajar" +
                            "\nRopa restante: " + cantRopa;

            if (cantRopa <=0)
            {
                textRopa.text = "Recogiste la ropa :)";
            }
        }
    }



    // Recoger los platos 
    // Recoger la ropa 
    // Recoger la basura
}
