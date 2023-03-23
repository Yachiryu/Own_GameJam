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
    public bool totbasura, totropa, totplatos, totingredientes, totdinero;
    public bool objetivosCumplidos;

    public Sonidos sonidos;

    //CarroVictoria carroV;

    private void Start()
    {
        cantBasura = GameObject.FindGameObjectsWithTag("Basura").Length;
        cantRopa = GameObject.FindGameObjectsWithTag("Ropa").Length;
        cantPlatos = GameObject.FindGameObjectsWithTag("Platos").Length;
        cantIngredentes = GameObject.FindGameObjectsWithTag("Ingrediente").Length;

        sonidos = FindObjectOfType<Sonidos>();

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
        CondicionVictoria();

    }

    public void CantidadBasura() 
    {
        textBasura.text = "Recoge la basura y metela al contenedor" +
                          "\nRestantes: " + cantBasura;

        if (cantBasura <= 0)
        {
            textBasura.text = "Basura recogida";
            totbasura = true;
            //sonidos.SonidoObjetivo();
        }
        if (totbasura == true)
        {

        }
    }
    public void PagoImpuestos()
    {
        textServicios.text = "Consigue los 750 dolares de la hipoteca";

        if (cantDinero >= 750)
        {
            textServicios.text = "Dinero conseguido";
            totdinero = true;
            //sonidos.SonidoObjetivo();
        }
    }
    public void CantidadPlatos()
    {
        textPlatos.text = "Recoge los platos" +
                          "\nRestantes: " + cantPlatos;

        if (cantPlatos <= 0)
        {
            textPlatos.text = "Platos Recogidos";
            totplatos = true;
            //sonidos.SonidoObjetivo();
        }
    }
    public void CantidadIngredientes()
    {
        textIngredientes.text = "¡Arma tu almuerzo!" +
                                "\nRestantes: " + cantIngredentes;

        if (cantIngredentes <= 0)
        {
            textIngredientes.text = "Almuerzo listo";
            totingredientes = true;
            //sonidos.SonidoObjetivo();
        }
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Ropa")
        {
            Destroy(collision.gameObject);
            cantRopa--;
            sonidos.SonidoRecoger();
            textRopa.text = "Recoge la ropa para ir a trabajar" +
                           "\nRopa restante: " + cantRopa;

            if (cantRopa <=0)
            {
                textRopa.text = "Recogiste la ropa :)";
                totropa = true;
            }
        }
    }
    public void CondicionVictoria()
    {
        if (totbasura && totropa && totplatos && totingredientes && totdinero)
        {
            objetivosCumplidos = true;
            //sonidos.SonidoObjetivoGen();
        }
        /*if (objetivosCumplidos == true)
        {
            //sonidos.SonidoObjetivoGen();
        }*/
    }
}
