using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SliderHealthView : MonoBehaviour
{
    [SerializeField] private Health _health;
    [SerializeField] private Slider _smoothSlider;
    [SerializeField] private Slider _slider;
    [SerializeField] private float _smoothSpeed = 30f;

    private float _targetHealth = 100;
    private WaitForSeconds _waitForSeconds;
    private float _delay;

    private void OnEnable()
    {
        _health.HealthUpdated += UpdateCounterDisplay;
    }

    private void OnDisable()
    {
        _health.HealthUpdated -= UpdateCounterDisplay;
    }

    private void Start()
    {
        _waitForSeconds = new WaitForSeconds(_delay);
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
        yield return _waitForSeconds;

        while (_smoothSlider.value != _targetHealth)
        {
            _smoothSlider.value = Mathf.MoveTowards(_smoothSlider.value, _targetHealth, _smoothSpeed * Time.deltaTime);
            yield return null;
        }
    }
}