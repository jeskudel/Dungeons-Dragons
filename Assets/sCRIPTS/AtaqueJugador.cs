using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class AtaqueJugador : MonoBehaviour
{
    public GameObject bolaPrefab;
    public float velocidadBola;
    public Transform puntoAtaque;
    public ActionBasedController controlador;
    public AudioClip sonidoAtaque;


   public void BolaFuego()
    {
        GameObject bola = Instantiate(bolaPrefab, puntoAtaque.position, puntoAtaque.rotation);
        bola.GetComponent<Rigidbody>().velocity = (puntoAtaque.forward * velocidadBola);
        //this.gameObject.GetComponent<AudioSource>().Play();
        
    }

    private void Start()
    {
        
    }

    private void Update()
    {
        if (controlador.activateAction.action.ReadValue<float>() != 0)
        {
            BolaFuego();
        }
    }
}
