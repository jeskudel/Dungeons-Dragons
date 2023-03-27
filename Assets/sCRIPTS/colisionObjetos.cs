using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionObjetos : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision EMPEZADA!");
        Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
       // Debug.Log("Colision SE MANTIENE!");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Colision FINAL!");
        Debug.Log(collision.gameObject.name);

    }
}
