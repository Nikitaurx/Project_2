using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthUp : MonoBehaviour
{
    private GameObject _player;
    private GameObject _healthUp;
    private bool _collidedWithPlayer;
    [SerializeField] private float _heal;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject == _player)
        {
            _player.GetComponent<HealthHero>().HpRegen(_heal);
            print("enter collided with _player");
            Destroy(_healthUp);
        }        
    }

    void Awake()
    {
        _player = GameObject.FindGameObjectWithTag("Player");
        _healthUp = GameObject.FindGameObjectWithTag("HealthUp");
    }
}
