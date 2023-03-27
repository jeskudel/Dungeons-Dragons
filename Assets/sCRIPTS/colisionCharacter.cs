using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionCharacter : MonoBehaviour
{
    CharacterController _jugador;
    Animator _animador;
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
        //Debug.Log(hit.gameObject.name);
    }
}
