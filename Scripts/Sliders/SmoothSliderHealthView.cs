using System.Collections;
using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Slider))]
public class SmoothSliderHealthView : Slider
{
    [SerializeField] private float _smoothSpeed = 30f;

    private UnityEngine.UI.Slider _smoothSlider;

    private void Awake()
    {
        _smoothSlider = GetComponent<UnityEngine.UI.Slider>();
    }

    protected override void UpdateCounterDisplay(float health)
    {
        _targetHealth = health;
        StartCoroutine(SmoothHealthChange());
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
