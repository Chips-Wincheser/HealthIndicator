using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class HealthView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _counterText;
    [SerializeField] private Health _health;
    [SerializeField] private Slider _smoothSlider;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothSpeed = 30f;

    private float _targetHealth=100;

    private void OnEnable()
    {
        _health.HealthUpdated += UpdateCounterDisplay;
    }

    private void OnDisable()
    {
        _health.HealthUpdated -= UpdateCounterDisplay;
    }

    private void Update()
    {
        if (_smoothSlider != null)
        {
            _smoothSlider.value = Mathf.MoveTowards(_smoothSlider.value, _targetHealth, _smoothSpeed * Time.deltaTime);
        }
    }

    private void UpdateCounterDisplay(float health)
    {
        _targetHealth = health;

        if (_counterText != null)
        {
            _counterText.text = health.ToString();
        }
        
        if (_slider != null)
        {
            _slider.value=health;
        }
    }
}