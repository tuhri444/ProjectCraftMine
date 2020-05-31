using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody BlockRig;
    private Vector3 _movementVector;
    [SerializeField] private float _speed;
    void Start()
    {
        BlockRig = GetComponentInChildren<Rigidbody>();
    }

    void Update()
    {
        _movementVector = new Vector3(Input.GetAxisRaw("Vertical"), 0, -Input.GetAxisRaw("Horizontal"));
        BlockRig.AddTorque(_movementVector * _speed * Time.deltaTime);
    }
}
