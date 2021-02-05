using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rBody2D;

    [SerializeField]
    float speed = 1;

    [SerializeField]
    float _jumpForce = 1;

    private void Awake()
    {
        rBody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    
    void Update()
    {
        float _horizontalValue = Input.GetAxis("Horizontal");
        //float _jumpValue = Input.GetAxis("Jump");

        //rBody2D.position += Vector2.right * _horizontalValue * speed * Time.deltaTime;
        var _velocity = rBody2D.velocity;
        _velocity.x = Vector3.right.x * _horizontalValue * speed;
        if (Input.GetKeyDown(KeyCode.Space))
            _velocity.y += Vector2.up.y * 1 * _jumpForce;

        rBody2D.velocity = _velocity;
    }
}
