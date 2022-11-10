using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSpotLight : MonoBehaviour
{
    [SerializeField] private GameObject _target;
    [SerializeField] private Vector3 _position_1;
    [SerializeField] private Vector3 _position_2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.right * Time.deltaTime);
    }
}
