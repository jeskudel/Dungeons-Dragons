using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlVidas : MonoBehaviour
{
    [Header("Vidas")]
    public int vidasActual;
    public int vidasMax;

    // Start is called before the first frame update
    void Start()
    {
        vidasMax = vidasActual;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void QuitarVidas(int cantidadVida) 
    {
        vidasActual -= cantidadVida;
        if (vidasActual <= 0 && this.gameObject.CompareTag("personaje"))
        {
            terminarJuego();
        }
        else if (vidasActual <= 0 && this.gameObject.CompareTag("enemigo"))
        {
            Destroy(this.gameObject);
        }
            
    }

    private void terminarJuego()
    {
        Debug.Log("GAME OVER!!");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
