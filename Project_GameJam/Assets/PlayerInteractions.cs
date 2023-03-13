using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public Transform CameraPlayer;
    public Transform ObjetoVacio;
    public LayerMask lm;
    //public GameObject Arma;
    //public Transform ObjetoVacioArma;
    public float rayDistance;

    private void Update()
    {
        Debug.DrawRay(CameraPlayer.position, CameraPlayer.forward * rayDistance, Color.red);

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (ObjetoVacio.childCount > 0)
            {
                ObjetoVacio.GetComponentInChildren<Rigidbody>().isKinematic = false;
                ObjetoVacio.DetachChildren();
                Debug.Log("collision");
   
            }
            else
            {
                if (Physics.Raycast(CameraPlayer.position, CameraPlayer.forward, out RaycastHit hit, rayDistance, lm))
                {
                    hit.transform.GetComponent<Rigidbody>().isKinematic = true;
                    hit.transform.parent = ObjetoVacio;
                    hit.transform.localPosition = Vector3.zero;
                    hit.transform.localRotation = Quaternion.identity;
                    Debug.Log("collision2");

                }
            }

        }

    }

}
