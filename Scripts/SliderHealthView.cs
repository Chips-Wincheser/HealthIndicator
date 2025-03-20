using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderHealthView : MonoBehaviour
{
    [SerializeField] private Health _healthPlayer;
    [SerializeField] private Slider _smoothSlider;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothSpeed = 30f;

    private float _targetHealth = 100;

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
        _targetHealth = health;

        if (_slider != null)
        {
            _slider.value=health;
        }
        else if (_smoothSlider != null)
        {
            StartCoroutine(SmoothHealthChange());
        }
    }

    private IEnumerator SmoothHealthChange()
    {
        while (_smoothSlider.value != _targetHealth)
        {
            _smoothSlider.value = Mathf.MoveTowards(_smoothSlider.value, _targetHealth, _smoothSpeed * Time.deltaTime);
            yield return null;
        }
    }
}