using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ControlVidas : MonoBehaviour
{
    [Header("Vidas")]
    public int vidasActual;
    public int vidasMax;
    public Slider barraVida;

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

    public void QuitarVidas(int cantidadVida) 
    {
        vidasActual -= cantidadVida;
        barraVida.value = vidasActual;
        if (vidasActual <= 0 && this.gameObject.CompareTag("personaje"))
        {
            terminarJuego();
        }
        else if (vidasActual <= 0 && this.gameObject.CompareTag("enemigo") || vidasActual <= 0 && this.gameObject.CompareTag("goblin"))
        {
            if (this.gameObject.CompareTag("goblin"))
            {
                this.GetComponent<Animator>().Play("morir");
            }
            Destroy(this.gameObject, 5);
        }
            
    }

    private void terminarJuego()
    {
        Debug.Log("GAME OVER!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
