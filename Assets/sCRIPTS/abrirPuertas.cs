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
            //Debug.Log("activar apertura");
            _animador.SetTrigger("abrir");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "personaje")
        {
            //Debug.Log("desactivar apertura");
            _animador.SetTrigger("cerrar");
        }
    }
  
}
