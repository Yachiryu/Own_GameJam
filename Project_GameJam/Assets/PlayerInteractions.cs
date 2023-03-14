using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteractions : MonoBehaviour
{
    public Transform CameraPlayer;
    public Transform ObjetoVacio;
    public LayerMask lm;
    public float rayDistance;
    public bool tieneObjeto;

    public Crouch crouch;

    private void Start()
    {
        crouch = FindObjectOfType<Crouch>();
    }

    private void Update()
    {
        RecogerObjects();
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

}
