using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlAtaqueGoblin : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float velocidadBola;
    public Transform puntoAtaque;
    public float frecuenciaDisparo;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("personaje"))
        {
            StartCoroutine("Atacar");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("personaje"))
        {
            StopCoroutine("Atacar");
        }
    }

    public IEnumerator Atacar()
    {
        while (true)
        {
            transform.LookAt(GameObject.FindGameObjectWithTag("personaje").transform);
            yield return new WaitForSeconds(0.2f);
            // GameObject bola = Instantiate(bolaPrefab, puntoAtaque.position, puntoAtaque.rotation);
            // bola.GetComponent<Rigidbody>().velocity = (puntoAtaque.forward * velocidadBola);
            // this.gameObject.GetComponent<AudioSource>().Play();
            //animacion de atacar
            if (GetComponent<Animator>())
            {
                this.GetComponent<Animator>().Play("atacar");
            }
            yield return new WaitForSeconds(frecuenciaDisparo);
        }
    }

    public void Disparar()
    {
        GameObject bola = Instantiate(bolaPrefab, puntoAtaque.position, puntoAtaque.rotation);
        bola.GetComponent<Rigidbody>().velocity = (puntoAtaque.forward * velocidadBola);
        this.gameObject.GetComponent<AudioSource>().Play();
    }   

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
