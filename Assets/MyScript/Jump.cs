using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    [SerializeField] private float JumpStrength = 2f;
    [SerializeField] private float maxGroundDistance = 0.3f;

    private Rigidbody _rigidbody;
    private Transform _groundCheckObject;

    private bool isGrounded;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody>();
        _groundCheckObject = GameObject.FindGameObjectWithTag("GroundCheck").transform;

    }

    private void Update()
    {
        isGrounded = Physics.Raycast(_groundCheckObject.transform.position, Vector3.down, maxGroundDistance);

        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            _rigidbody.AddForce(Vector3.up * 100 * JumpStrength);
            Debug.Log("Jump");
        }
    }

}
