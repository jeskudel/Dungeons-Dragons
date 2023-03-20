using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class saltarPlayer : MonoBehaviour
{
    [SerializeField] private InputActionReference jumpButton;
    [SerializeField] private float fuerzaSalto = 2f;
    [SerializeField] private float gravedad = -9.81f;

    private CharacterController _jugador;
    private Vector3 _playerVelocity;

    // Start is called before the first frame update
    void Awake()
    {
        _jugador = GetComponent<CharacterController>();
    }

    private void OnEnable() => jumpButton.action.performed += Saltar;
    private void OnDisable() => jumpButton.action.performed -= Saltar;

    private void Saltar(InputAction.CallbackContext obj)
    {
        if (!_jugador.isGrounded)
        {
            return;
        }
        _playerVelocity.y = MathF.Sqrt((-fuerzaSalto) * gravedad);

    }

    // Update is called once per frame
    void Update()
    {
        if (_jugador.isGrounded && _playerVelocity.y < 0)
        {
            _playerVelocity.y = 0;
        }
        _playerVelocity.y += gravedad * Time.deltaTime;
        _jugador.Move(_playerVelocity * Time.deltaTime);
    }
}
