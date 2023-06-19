using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NoGravityMovePlayer : MonoBehaviour
{
    private float _PlayerSpeed;

    private SpriteRenderer _sr;
    private Rigidbody _rb;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody>();
        _sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        PlayerController();
        PlayerSpeed();
        PlayerRotation();
    }

    private void PlayerController()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * _PlayerSpeed;
        float v =Input.GetAxis("Vertical") * Time.deltaTime * _PlayerSpeed;
        _rb.velocity = transform.TransformDirection(new Vector3(h, v, 0));
    }
    
    private void PlayerSpeed()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            _PlayerSpeed = 90f;
        }   
        else
        {
            _PlayerSpeed = 40f;
        }
    }
    public void PlayerRotation()
    {
        if(Input.GetKey(KeyCode.D))
        {
            _sr.flipX = true;
        }
        if(Input.GetKey(KeyCode.A))
        {
            _sr.flipX = false;
        }
    }
}