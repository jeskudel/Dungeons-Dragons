using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public class abrirPuertas : MonoBehaviour
{
    GameObject puerta;
    Animator _animador;
    private void Start()
    {
        _animador = GetComponentInChildren<Animator>();
        //_animador = GetComponent<Animator>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "personaje")
        {
            //this.gameObject.GetComponent<MeshRenderer>().enabled = false;
            Debug.Log("activar apertura");
            //_animador.ResetTrigger("cerrar");
            _animador.SetTrigger("abrir");
        } else
        {
            Debug.Log(other.tag);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "personaje")
        {
            Debug.Log("desactivar apertura");
            //_animador.ResetTrigger("abrir");
            _animador.SetTrigger("cerrar");
        }
        //this.gameObject.GetComponent<MeshRenderer>().enabled = true;
    }
  
}
