using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lifebar : MonoBehaviour
{
    [SerializeField] public Image lifebar;
    public float health;
    public float maxHealth = 5f;

    void Start()
    {
        health = maxHealth;
    }

    void Update()
    {
        
        lifebar.fillAmount = health / maxHealth;
    }

    public void ChangeHealth(float newHealth)
    {
        health = newHealth;
        if (health < 0)
        {
            health = 0;
        }else if (health>maxHealth)
        {
            health = maxHealth;
        }
    }

    public void ChangeMaxHealth(float newHealth)
    {
        maxHealth = newHealth;
    }

    
}