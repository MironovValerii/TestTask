using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class AlienController : MonoBehaviour
{
    [SerializeField] private FixedJoystick _joystick;
    [SerializeField] private Animator _animator;
    [SerializeField] private float Speed = 10f;
    [SerializeField] private float JumpForce = 300f;
    private bool _isGrounded;
    private Rigidbody _rb;
    [SerializeField] private Canvas _canvas;

    private void Start()
    {
        _canvas.GetComponent<OrientationSetter>().OrientationLandscape();
        _rb = GetComponent<Rigidbody>();
    }
    private void FixedUpdate()
    {
        MovementLogic();
    }
    private void MovementLogic()
    {
        float moveHorizontal = _joystick.Horizontal;
        float moveVertical = _joystick.Vertical;
        Vector3 movement = new Vector3(_joystick.Horizontal, 0.0f, _joystick.Vertical);
        _rb.AddForce(movement * Speed);
        if (_joystick.Horizontal != 0 || _joystick.Vertical != 0)
        {
            transform.rotation = Quaternion.LookRotation(movement);
            _animator.SetBool("isRunning", true);
        }
        else
            _animator.SetBool("isRunning", false);
    }
    public void JumpLogic()
    {
        if (_isGrounded)
        {
            _rb.AddForce(Vector3.up * JumpForce);
            _animator.SetBool("isJumping", true);

        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        IsGroundedUpate(collision, true);
        _animator.SetBool("isJumping", false);
    }
    private void OnCollisionExit(Collision collision)
    {
        IsGroundedUpate(collision, false);
    }
    private void IsGroundedUpate(Collision collision, bool value)
    {
        if (collision.gameObject.tag == ("Ground"))
        {
            _isGrounded = value;
        }
    }
}