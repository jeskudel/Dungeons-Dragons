using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCharacter : MonoBehaviour
{
    CharacterController _jugador;
    // Start is called before the first frame update
    void Start()
    {
        _jugador = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
      
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        //Debug.Log("Colision EMPEZADA!");
        //Debug.Log(_jugador.collisionFlags);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.name);
    }
}
