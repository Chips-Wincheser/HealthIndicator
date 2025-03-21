using System.Collections;
using UnityEngine;


public class SmoothSliderHealthView : Slider
{
    [SerializeField] private float _smoothSpeed = 30f;

    private Coroutine _currentCoroutine;

    protected override void UpdateCounterDisplay(float health)
    {
        _targetHealth = health;

        if(_currentCoroutine != null)
            StopCoroutine(_currentCoroutine);

        _currentCoroutine=StartCoroutine(SmoothHealthChange());
    }

    private IEnumerator SmoothHealthChange()
    {
        while (_slider.value != _targetHealth)
        {
            _slider.value = Mathf.MoveTowards(_slider.value, _targetHealth, _smoothSpeed * Time.deltaTime);
            yield return null;
        }

        _currentCoroutine = null;
    }
}
