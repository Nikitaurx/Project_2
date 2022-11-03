using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingHero : MonoBehaviour
{
    [SerializeField] private float movementSpeed = 5f;
    [SerializeField] private Animator _animator;

    // private bool runForward = false;
    // private bool runBackward = false;
    // private bool runRight = false;
    // private bool runLeft = false;
    private bool death = false;

    private Vector2 velocity;

    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    private void Update()
    {
        if (death == false)
        {
            velocity.x = Input.GetAxis("Horizontal") * movementSpeed * Time.deltaTime;
            velocity.y = Input.GetAxis("Vertical") * movementSpeed * Time.deltaTime;

            transform.Translate(velocity.x, 0f, velocity.y);
        }

        // AnimationForward();
        // AnimationBackward();
        // AnimationRight();
        // AnimationLeft();
        // AnimationDeath();

        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetFloat("Speed", 1);
            _animator.SetFloat("ForwardBackward", 1);
            _animator.SetFloat("LeftRight", 0);

            if (Input.GetKey(KeyCode.LeftShift))
            {
                _animator.SetFloat("Speed", 2);
                _animator.SetFloat("ForwardBackward", 1);
                _animator.SetFloat("LeftRight", 0);
                movementSpeed = 20;
            }
            movementSpeed = 10;
        }
        else if (Input.GetKey(KeyCode.S))
        {
            _animator.SetFloat("Speed", 1);
            _animator.SetFloat("ForwardBackward", -1);
            _animator.SetFloat("LeftRight", 0);
        }
        else if (Input.GetKey(KeyCode.A))
        {
            _animator.SetFloat("Speed", 1);
            _animator.SetFloat("ForwardBackward", 1);
            _animator.SetFloat("LeftRight", -1);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            _animator.SetFloat("Speed", 1);
            _animator.SetFloat("ForwardBackward", 1);
            _animator.SetFloat("LeftRight", 1);
        }
        else
        {
            _animator.SetFloat("ForwardBackward", 0);
            _animator.SetFloat("Speed", 0);
            _animator.SetFloat("LeftRight", 0);
        }

    }

    public void AnimationForward()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _animator.SetFloat("Speed", 1);
            _animator.SetFloat("ForwardBackward", 1);
            _animator.SetFloat("LeftRight", 0);

        }
        else
        {
            _animator.SetFloat("ForwardBackward", 0);
            _animator.SetFloat("Speed", 0);
            _animator.SetFloat("LeftRight", 0);
        }
    }
    public void AnimationBackward()
    {
        if (Input.GetKey(KeyCode.S))
        {
            _animator.SetFloat("ForwardBackward", -1);
            _animator.SetFloat("Speed", 1);
        }
        else
        {
            _animator.SetFloat("ForwardBackward", 0);
            _animator.SetFloat("Speed", 0);
        }
    }

    // private void AnimationForward()
    // {
    //     if (Input.GetKey(KeyCode.W))
    //     {
    //         runForward = true;
    //         _animator.SetBool("Run", runForward);
    //     }
    //     else
    //     {
    //         runForward = false;
    //         _animator.SetBool("Run", runForward);
    //     }
    // }

    // private void AnimationBackward()
    // {
    //     if (Input.GetKey(KeyCode.S))
    //     {
    //         runBackward = true;
    //         _animator.SetBool("BackwardRun", runBackward);
    //     }
    //     else
    //     {
    //         runBackward = false;
    //         _animator.SetBool("BackwardRun", runBackward);
    //     }
    // }
    // private void AnimationRight()
    // {
    //     if (Input.GetKey(KeyCode.D))
    //     {
    //         runRight = true;
    //         _animator.SetBool("RightRun", runRight);
    //     }
    //     else
    //     {
    //         runRight = false;
    //         _animator.SetBool("RightRun", runRight);
    //     }
    // }
    // private void AnimationLeft()
    // {
    //     if (Input.GetKey(KeyCode.A))
    //     {
    //         runLeft = true;
    //         _animator.SetBool("LeftRun", runLeft);
    //     }
    //     else
    //     {
    //         runLeft = false;
    //         _animator.SetBool("LeftRun", runLeft);
    //     }
    // }
    // public void AnimationDeath()
    // {
    //     float hp = GetComponent<HealthHero>()._currentHealth;
    //     if (hp <= 0)
    //     {
    //         death = true;
    //         _animator.SetBool("Death", death);
    //     }
    // }

}
