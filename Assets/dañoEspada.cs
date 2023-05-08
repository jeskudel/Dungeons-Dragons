using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dañoEspada : MonoBehaviour
{
    public int cantidadVida;
    // Start is called before the first frame update
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("goblin"))
        {
            collision.gameObject.GetComponent<controlGoblin>().QuitarVidas(cantidadVida);
        }
    }
   }