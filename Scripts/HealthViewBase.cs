using UnityEngine;

public abstract class HealthViewBase : MonoBehaviour
{
    [SerializeField] protected Health _healthPlayer;

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
