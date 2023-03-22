using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crouch : MonoBehaviour
{
    public GameObject character;
    public bool isAgachado = true;
    public PlayerInteractions playerInteractions;
    void Start()
    {
        character = this.gameObject;
        //Cursor.lockState = CursorLockMode.Locked;
        playerInteractions = FindObjectOfType<PlayerInteractions>();
    }

    void Update()
    {
        agacharse();
    }
    void agacharse() 
    {
        if (playerInteractions.tieneObjeto == false)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                character.transform.localScale += new Vector3(0,-0.7f, 0);
                isAgachado = true;
            }
        
            if (Input.GetKeyUp(KeyCode.LeftShift) && isAgachado)
            {
                    character.transform.localScale -= new Vector3(0,-0.7f, 0);
                    isAgachado = false;
            }
        }
        
    }
}
