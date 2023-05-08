using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class controlGoblin: MonoBehaviour
{
    [Header("Vidas")]
    public int vidasActual;
    public int vidasMax;
    public Slider barraVida;
    [Header("Ataque")]
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
        //this.gameObject.GetComponent<AudioSource>().Play();
    }

    public void QuitarVidas(int cantidadVida)
    {
        vidasActual -= cantidadVida;
        barraVida.value = vidasActual;
        if (vidasActual <= 0 && this.gameObject.CompareTag("personaje"))
        {
            terminarJuego();
        }
        else if (vidasActual <= 0 && this.gameObject.CompareTag("goblin"))
        {
            if (this.gameObject.CompareTag("goblin"))
            {
                this.GetComponent<Animator>().Play("morir");
                StopAllCoroutines();
            }
            Destroy(this.gameObject, 5);
        }
    }

    private void terminarJuego()
    {
        Debug.Log("GAME OVER!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Start is called before the first frame update
    void Start()
    {
        vidasMax = vidasActual;
        barraVida.value = barraVida.maxValue = vidasActual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
