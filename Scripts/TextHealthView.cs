using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class TextHealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Health _health;

    private float _targetHealth=100;

    private void OnEnable()
    {
        _health.HealthUpdated += UpdateCounterDisplay;
    }

    private void OnDisable()
    {
        _health.HealthUpdated -= UpdateCounterDisplay;
    }

    private void UpdateCounterDisplay(float health)
    {
        _targetHealth = health;

        if (_counterText != null)
        {
            _counterText.text = health.ToString();
        }
    }
}