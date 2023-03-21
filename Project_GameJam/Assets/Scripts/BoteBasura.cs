using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoteBasura : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Basura")
        {
            Destroy(collision.gameObject,1f);
            Debug.Log("Basurita");
        }
    }
}
