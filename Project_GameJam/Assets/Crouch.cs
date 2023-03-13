using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public GameObject character;
    public bool isAgachado = true;
    void Start()
    {
        character = this.gameObject;
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        agacharse();
    }
    void agacharse() 
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            //Debug.Log("agachado");
            character.transform.localScale = new Vector3(0, 0.6f, 0);
            isAgachado = true;
        }
        
        if (Input.GetKeyUp(KeyCode.LeftShift) && isAgachado)
        {
                //Debug.Log("parado");
                character.transform.localScale = new Vector3(0, 1, 0);
                isAgachado = false;
        }
        
    }
}
