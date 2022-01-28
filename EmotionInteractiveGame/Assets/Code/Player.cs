using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField]
    private float _speed;
    private PlayerMovement _playerActions;
    private Rigidbody _rbody;
    private Vector3 _moveInput;

    private void Awake()
    {
        _playerActions = new PlayerMovement();

        _rbody = GetComponent<Rigidbody>();
        if (_rbody is null)
            Debug.LogError("RigidBody is NULL!");
    }

    private void OnEnable()
    {
        _playerActions.Player_actions.Enable();
    }




}
