using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int _maxHealth = 100;

    private int _currentHealth;

    public event Action<float> HealthUpdated;

    private void Awake()
    {
        _currentHealth = _maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if (damage>0)
        {
            _currentHealth = Mathf.Clamp(_currentHealth - damage, 0, _maxHealth);
            HealthUpdated?.Invoke(_currentHealth);

            if (_currentHealth == 0)
            {
                Die();
            }
        }
    }

    public void Treatment(int healingAmount)
    {
        _currentHealth = Mathf.Clamp(_currentHealth + healingAmount, 0, _maxHealth);
        HealthUpdated?.Invoke(_currentHealth);
    }

    private void Die()
    {
        Destroy(gameObject);
    }
}