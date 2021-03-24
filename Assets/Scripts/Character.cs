using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public int maxHealth = 3;
    protected int _currentHealth = 3;
    protected bool _hasDied = false;

    private void Awake()
    {
        _currentHealth = maxHealth;
    }

    private void Update()
    {
        if (_currentHealth <= 0)
        {
            if (_hasDied == false)
            {
                Die();
            }
        }
        else
        {
            MovementBehavior();
        }
    }


    public virtual void MovementBehavior()
    {
    }
    public virtual void TakeDamage(int damageAmount)
    {
        _currentHealth = _currentHealth - damageAmount;
        _currentHealth = Mathf.Clamp(_currentHealth, 0, maxHealth);
    }
    public virtual void Die()
    {
        _hasDied = true;
        Destroy(gameObject);
    }

}
