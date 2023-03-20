using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class abrirPuertas : MonoBehaviour
{
    GameObject puerta;
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "personaje")
        {
            Debug.Log("Tag correcto!");
            Destroy(this.gameObject);
        } else
        {
            Debug.Log(other.tag);
            Destroy(this.gameObject);
        }
    }
    private void Start()
    {
        //puerta = GameObject.Find()
    }
}
