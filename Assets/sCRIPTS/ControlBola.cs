using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlBola : MonoBehaviour
{
    public int cantidadVida;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("personaje"))
        {
            collision.gameObject.GetComponent<ControlVidas>().QuitarVidas(cantidadVida);
            Debug.Log(collision.gameObject.name);
        }
        if (collision.gameObject.CompareTag("enemigo") || collision.gameObject.CompareTag("goblin"))
        {
            collision.gameObject.GetComponent<ControlVidas>().QuitarVidas(cantidadVida);
        }
        this.gameObject.GetComponent<AudioSource>().Play();
        Impacto();
    }

    private void Impacto()
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        this.gameObject.GetComponent<TrailRenderer>().enabled = false;
        Destroy(this.gameObject, 2);
    }
}
