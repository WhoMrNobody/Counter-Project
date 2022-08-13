using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float movementSpeed;
    Rigidbody _rb;

    private void Awake() {
        
        _rb = GetComponent<Rigidbody>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            _rb.velocity = Vector3.forward * movementSpeed;
        }
    }
}
