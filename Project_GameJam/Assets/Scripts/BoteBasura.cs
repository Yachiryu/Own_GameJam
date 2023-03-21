using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoteBasura : MonoBehaviour
{
    public Objetivos objetivos;
    void Start()
    {
        objetivos = FindObjectOfType<Objetivos>();
    }
    
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Basura")
        {
            Destroy(collision.gameObject,0.5f);
            objetivos.cantBasura--;
            Debug.Log("Basurita");
        }
    }
}
