using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private float _PlayerSpeed;
    private float _JumpPower = 150f;

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
        PlayerJump();
        PlayerRotation();
    }

    private void PlayerController()
    {
        float h = Input.GetAxis("Horizontal") * Time.deltaTime * _PlayerSpeed;
        _rb.velocity = transform.TransformDirection(new Vector3(h, _rb.velocity.y, 0));
    }

    private void PlayerJump()
    {
        if(Input.GetKeyDown(KeyCode.W) && GroundCheck.PlayeOnGround == true)
        {
            _rb.AddForce(new Vector3(0, 1, 0) * _JumpPower);
        }
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