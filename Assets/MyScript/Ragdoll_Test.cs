using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ragdoll_Test : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    private Rigidbody[] rb_AR;
    public GameObject _player;
    private IK_Test linkForLookObj;
    //public bool checkLookObj = false;
    void Start()
    {
        rb_AR = GetComponentsInChildren<Rigidbody>();
        foreach (Rigidbody rb in rb_AR)
        {
            rb.isKinematic = true;
        }
        _animator = GetComponent<Animator>();
        linkForLookObj = GetComponent<IK_Test>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            Active_ragdoll();
        }
    }
    void Active_ragdoll()
    {
        foreach (Rigidbody rb in rb_AR) rb.isKinematic = false;
        GetComponent<Animator>().enabled = false;
    }
    public void OnTriggerEnter(Collider other)
    {
        print("player stay in collider");
        if (other.gameObject == _player)
        {
            linkForLookObj.checkLookObj = true;
        }
        else linkForLookObj.checkLookObj = false;
    }
    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
    }
}
