using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthHero : MonoBehaviour
{
    //public Slider HealthBar;
    public float maxHealth = 3;
    public float _currentHealth;
    public bool visible = true;
    public GUISkin mySkin;


    void Start()
    {
        _currentHealth = maxHealth;
    }
    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        //HealthBar.value = _currentHealth;
        Debug.Log(_currentHealth);
    }

    public void HpRegen(float hpUp)
    {
        _currentHealth += hpUp;
        //HealthBar.value = _currentHealth;
        Debug.Log(_currentHealth);
    }

    private void OnGUI()
    {
        if (visible)
        {
            GUI.skin = mySkin;
            float HealthBarLenght = _currentHealth / maxHealth;
            GUI.Box(new Rect(10, 15, 254 * HealthBarLenght, 30), "", GUI.skin.GetStyle("HPbar"));
        }
    }
    void Update()
    {
        // if (_currentHealth <= 0)
        // {
        //     Destroy(gameObject);
        // }
    }
}
