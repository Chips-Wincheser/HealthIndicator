using UnityEngine;

public abstract class Slider : MonoBehaviour
{
    [SerializeField] protected Health _healthPlayer;

    protected float _targetHealth = 100;

    private void OnEnable()
    {
        _healthPlayer.HealthUpdated += UpdateCounterDisplay;
    }

    private void OnDisable()
    {
        _healthPlayer.HealthUpdated -= UpdateCounterDisplay;
    }

    protected abstract void UpdateCounterDisplay(float health);
}