using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public Transform CameraPlayer;
    public Transform ObjetoVacio;
    public LayerMask lm; 
    public LayerMask lm2;
    public float rayDistance;
    public bool tieneObjeto;

    public Crouch crouch;
    public TaxesPuntos taxes;
    public Objetivos objetivos;

    private void Start()
    {
        crouch = FindObjectOfType<Crouch>();
        taxes = FindObjectOfType<TaxesPuntos>();
        objetivos = FindObjectOfType<Objetivos>();
    }

    private void Update()
    {
        RecogerObjects();
        ObjetivesInteracciones();
    }
    public void RecogerObjects()
    {
        Debug.DrawRay(CameraPlayer.position, CameraPlayer.forward * rayDistance, Color.red);

        if (crouch.isAgachado == false)
        {
            if (Input.GetKeyDown(KeyCode.R))
            {
                if (ObjetoVacio.childCount > 0)
                {
                    ObjetoVacio.GetComponentInChildren<Rigidbody>().isKinematic = false;
                    ObjetoVacio.DetachChildren();
                    tieneObjeto = true;

                }
                else
                {
                    if (Physics.Raycast(CameraPlayer.position, CameraPlayer.forward, out RaycastHit hit, rayDistance, lm))
                    {
                        hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                        hit.transform.parent = ObjetoVacio;
                        hit.transform.localPosition = Vector3.zero;
                        hit.transform.localRotation = Quaternion.identity;
                        tieneObjeto = true;

                    }
                }

            }
        }
        if (ObjetoVacio.childCount <= 0)
        {
            tieneObjeto = false;
        }

    }
    public void ObjetivesInteracciones() 
    {
        Debug.DrawRay(CameraPlayer.position, CameraPlayer.forward * rayDistance, Color.green);

        if (Physics.Raycast(CameraPlayer.position, CameraPlayer.forward, out RaycastHit hit, rayDistance, lm2) && Input.GetKey(KeyCode.Mouse0))
        {
            if (hit.collider.gameObject.tag == ("Billete100dll"))
            {
                Debug.Log("Platica100");
                taxes.moneyCount += 100;
                objetivos.cantDinero += 100;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.tag == ("Billete50dll"))
            {
                Debug.Log("Platica50");
                taxes.moneyCount += 50;
                objetivos.cantDinero += 50;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.tag == ("Billete30dll"))
            {
                Debug.Log("Platica30");
                taxes.moneyCount += 30;
                objetivos.cantDinero += 30;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.tag == ("Ingrediente"))
            {
                Debug.Log("Ingredientes");
                objetivos.cantIngredentes--;
                Destroy(hit.collider.gameObject);
            }
            if (hit.collider.gameObject.tag == ("Platos"))
            {
                Debug.Log("plato");
                objetivos.cantPlatos --;
                Destroy(hit.collider.gameObject);
            }

        }
        
    }


}
