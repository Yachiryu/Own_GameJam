using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public GameObject character;
    public bool isAgachado = false;
    void Start()
    {
        character = this.gameObject;
    }

    void Update()
    {
        agacharse();
    }
    void agacharse() 
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            Debug.Log("agachado");
            character.transform.position = new Vector3(0, 1.1f, 0);
            //isAgachado = true;
        }
        
        /*if (Input.GetKey(KeyCode.LeftShift) && isAgachado)
        {
                Debug.Log("parado");
                character.transform.localScale = new Vector3(1, 1f, 1);
                isAgachado = false;
        }*/
        
    }
}
