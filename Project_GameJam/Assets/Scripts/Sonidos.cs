using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sonidos : MonoBehaviour
{
    public AudioClip fxDinero, fxComida, fxRecoger;
        //fxObjetivo, fxObjetivoGen;

    public void SonidoDinero() 
    {
        AudioSource.PlayClipAtPoint(fxDinero, gameObject.transform.position);
    }
    public void SonidoComida() 
    {
        AudioSource.PlayClipAtPoint(fxComida, gameObject.transform.position);
    }
    public void SonidoRecoger() 
    {
        AudioSource.PlayClipAtPoint(fxRecoger, gameObject.transform.position);
    }
    /*public void SonidoObjetivo() 
    {
        AudioSource.PlayClipAtPoint (fxObjetivo, gameObject.transform.position);
    }
    public void SonidoObjetivoGen() 
    {
        AudioSource.PlayClipAtPoint(fxObjetivoGen, gameObject.transform.position);
    }*/
}
