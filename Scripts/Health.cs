using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    private float _currentHealth;

    public float MaxHealth {  get; private set; }

    public event Action<float> HealthUpdated;

    private void Awake()
    {
        MaxHealth  = 100;
        _currentHealth = MaxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (damage>0)
        {
            _currentHealth = Mathf.Clamp(_currentHealth - damage, 0, MaxHealth);
            HealthUpdated?.Invoke(_currentHealth/MaxHealth);

            if (_currentHealth == 0)
            {
                Die();
            }
        }
    }

    public void Treatment(int healingAmount)
    {
        if(healingAmount>0)
        {
            _currentHealth = Mathf.Clamp(_currentHealth + healingAmount, 0, MaxHealth);
            HealthUpdated?.Invoke(_currentHealth/MaxHealth);
        }
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}