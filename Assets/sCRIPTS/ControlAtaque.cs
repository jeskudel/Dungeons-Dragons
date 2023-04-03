using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlAtaque : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float velocidadBola;
    public Transform puntoAtaque;
    bool jugadorDetectado;
  
    public float frecuenciaDisparo;
    private float ultimoDisparo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("personaje"))
        {
            StartCoroutine("Atacar");
            Debug.Log("personaje ha entrado!!");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("personaje"))
        {
            StopCoroutine("Atacar");
            Debug.Log("personaje ha salido!!");
        }
    }

    public IEnumerator Atacar()
    {
        while (true)
        {
            transform.LookAt(GameObject.FindGameObjectWithTag("personaje").transform);
            yield return new WaitForSeconds(0.2f);
            GameObject bola = Instantiate(bolaPrefab, puntoAtaque.position, puntoAtaque.rotation);
            bola.GetComponent<Rigidbody>().velocity = (puntoAtaque.forward * velocidadBola);
            this.gameObject.GetComponent<AudioSource>().Play();
            //animacion de atacar
            yield return new WaitForSeconds(frecuenciaDisparo);
            
        }
    }
}
