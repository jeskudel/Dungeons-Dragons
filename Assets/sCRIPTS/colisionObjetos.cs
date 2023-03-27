using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionObjetos : MonoBehaviour
{
    private void Start()
    {
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("Colision EMPEZADA!");
        Debug.Log(collision.gameObject.name);
    }
    private void OnCollisionStay(Collision collision)
    {
        //Debug.Log("Colision SE MANTIENE!");
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("Colision FINAL!");
        Debug.Log(collision.gameObject.name);
    }
    private void OnTriggerEnter(Collider objeto)
    {
        Debug.Log("Trigger EMPEZADA!");
        Debug.Log(objeto.gameObject.name);
    }
    private void OnTriggerStay(Collider objeto)
    {
        //Debug.Log("Trigger SE MANTIENE!");
    }
    private void OnTriggerExit(Collider objeto)
    {
        Debug.Log("Trigger FINAL!");
        Debug.Log(objeto.gameObject.name);
    }
}
