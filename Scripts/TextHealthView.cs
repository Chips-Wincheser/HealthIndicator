using TMPro;
using UnityEngine;

public class TextHealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Health _healthPlayer;

    private void OnEnable()
    {
        _healthPlayer.HealthUpdated += UpdateCounterDisplay;
    }

    private void OnDisable()
    {
        _healthPlayer.HealthUpdated -= UpdateCounterDisplay;
    }

    private void UpdateCounterDisplay(float health)
    {
        if (_counterText != null)
        {
            _counterText.text = health.ToString();
        }
    }
}