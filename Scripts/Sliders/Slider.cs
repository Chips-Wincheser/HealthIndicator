using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Slider))]
public class Slider : HealthViewBase
{
    [SerializeField] protected UnityEngine.UI.Slider _slider;

    protected float _targetHealth = 100;

    private void Awake()
    {
        _slider = GetComponent<UnityEngine.UI.Slider>();
    }

    protected override void UpdateCounterDisplay(float health) { }
}