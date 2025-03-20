using UnityEngine;

[RequireComponent(typeof(UnityEngine.UI.Slider))]
public class SharpSliderHealthView : Slider
{
    private UnityEngine.UI.Slider _slider;

    private void Awake()
    {
        _slider = GetComponent<UnityEngine.UI.Slider>();
    }

    protected override void UpdateCounterDisplay(float health)
    {
        _slider.value = health;
    }
}
